using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class GeneroController : Controller
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroController(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        // GET: GeneroController
        public ActionResult Index()
        {
            var generos = _generoRepository.GetAll();
            var generoViewModelList = new List<GeneroViewModel>();

            foreach (var genero in generos)
                generoViewModelList.Add(new GeneroViewModel(genero));

            return View(generoViewModelList);
        }

        // GET: GeneroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var generoViewModel = new GeneroViewModel();
                var genero = generoViewModel.ToGenero(collection);
                _generoRepository.Create(genero);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneroController/Edit/5
        public ActionResult Edit(int id)
        {
            var genero = _generoRepository.GetById(id);
            var generoViewModel = new GeneroViewModel(genero);
            return View(generoViewModel);
        }

        // POST: GeneroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var generoViewModel = new GeneroViewModel();
                var genero = generoViewModel.ToGenero(collection);
                _generoRepository.Update(genero);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
