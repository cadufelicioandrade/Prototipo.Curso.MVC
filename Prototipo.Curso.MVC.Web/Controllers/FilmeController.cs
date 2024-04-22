using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IGeneroRepository _generoRepository;
        private readonly IDiretorRepository _diretorRepository;

        public FilmeController(IFilmeRepository filmeRepository, 
                                IGeneroRepository generoRepository, 
                                IDiretorRepository diretorRepository)
        {
            _filmeRepository = filmeRepository;
            _generoRepository = generoRepository;
            _diretorRepository = diretorRepository;
        }

        // GET: FilmeController
        public ActionResult Index()
        {
            var filmes = _filmeRepository.GetAll();
            var filmeViewModelList = new List<FilmeViewModel>();

            foreach (var filme in filmes)
                filmeViewModelList.Add(new FilmeViewModel(filme));

            return View(filmeViewModelList);
        }

        // GET: FilmeController/Details/5
        public ActionResult Details(int id)
        {
            var filme = _filmeRepository.GetById(id);
            var filmeViewModel = new FilmeViewModel(filme);
            return View(filmeViewModel);
        }

        // GET: FilmeController/Create
        public ActionResult Create()
        {
            var diretores = _diretorRepository.GetAll();
            var generos = _generoRepository.GetAll();
            var diretorViewModelList = new List<DiretorViewModel>();
            var generoViewModelList = new List<GeneroViewModel>();

            foreach (var diretor in diretores)
                diretorViewModelList.Add(new DiretorViewModel(diretor));
            foreach (var genero in generos)
                generoViewModelList.Add(new GeneroViewModel(genero));

            ViewBag.diretorViewModelList = new MultiSelectList(diretorViewModelList, "DiretorId", "NomeDiretor");
            ViewBag.generoViewModelList = new MultiSelectList(generoViewModelList, "GeneroId", "NomeGenero");

            return View();
        }

        // POST: FilmeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var filme = new Filme()
                {
                    TituloFilme = collection["TituloFilme"].ToString(),
                    Ano = Convert.ToInt32(collection["Ano"]),
                    ValorDiaria = Convert.ToDecimal(collection["ValorDiaria"]),
                    Disponivel = collection["Disponivel"].ToString().Contains("true") ? true : false,
                    DiretorId = Convert.ToInt32(collection["DiretorId"]),
                    GeneroId = Convert.ToInt32(collection["GeneroId"])
                };
                _filmeRepository.Create(filme);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FilmeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
