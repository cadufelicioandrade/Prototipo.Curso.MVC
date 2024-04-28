using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class EstadoController : Controller
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoController(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        // GET: EstadoController
        public ActionResult Index()
        {
            var estados = _estadoRepository.GetAll();
            var estadoViewModelList = new List<EstadoViewModel>();

            foreach (var estado in estados)
                estadoViewModelList.Add(new EstadoViewModel(estado));

            return View(estadoViewModelList);
        }

        // GET: EstadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var estadoViewModel = new EstadoViewModel();
                var estado = estadoViewModel.ToEstado(collection);

                _estadoRepository.Create(estado);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstadoController/Edit/5
        public ActionResult Edit(int id)
        {
            var estado = _estadoRepository.GetById(id);
            var estadoViewModel = new EstadoViewModel(estado);

            return View(estadoViewModel);
        }

        // POST: EstadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var estadoViewModel = new EstadoViewModel();
                var estado = estadoViewModel.ToEstado(collection);

                _estadoRepository.Update(estado);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
