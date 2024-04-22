using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class DiretorController : Controller
    {
        private readonly IDiretorRepository _diretorRepository;

        public DiretorController(IDiretorRepository diretorRepository)
        {
            _diretorRepository = diretorRepository;
        }

        // GET: DiretorController
        public ActionResult Index()
        {
            var diretores = _diretorRepository.GetAll();
            var diretorViewModelList = new List<DiretorViewModel>();

            foreach (var diretor in diretores)
                diretorViewModelList.Add(new DiretorViewModel(diretor));

            return View(diretorViewModelList);
        }

        // GET: DiretorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiretorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var diretor = new Diretor()
                {
                    Nome = collection["NomeDiretor"]
                };
                _diretorRepository.Create(diretor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiretorController/Edit/5
        public ActionResult Edit(int id)
        {
            var diretor = _diretorRepository.GetById(id);
            var diretorViewModel = new DiretorViewModel(diretor);
            return View(diretorViewModel);
        }

        // POST: DiretorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var diretor = new Diretor()
                {
                    Id = Convert.ToInt32(collection["DiretorId"]),
                    Nome = collection["NomeDiretor"].ToString()
                };
                _diretorRepository.Update(diretor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
