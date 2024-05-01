using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class LocacaoController : Controller
    {
        private readonly ILocacaoRepository _locacaoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IFilmeRepository _filmeRepository;

        public LocacaoController(ILocacaoRepository locacaoRepository, 
                                IClienteRepository clienteRepository, 
                                IFilmeRepository filmeRepository)
        {
            _locacaoRepository = locacaoRepository;
            _clienteRepository = clienteRepository;
            _filmeRepository = filmeRepository;
        }


        // GET: LocacaoController
        public ActionResult Index()
        {
            var locacoes = _locacaoRepository.GetAll();
            var locacaoViewModelList = new List<LocacaoViewModel>();

            foreach (var locacao in locacoes)
                locacaoViewModelList.Add(new LocacaoViewModel(locacao));

            return View(locacaoViewModelList);
        }

        // GET: LocacaoController/Details/5
        public ActionResult Details(int id)
        {
            var locacao = _locacaoRepository.GetById(id);
            var locacaoViewModel = new LocacaoViewModel(locacao);

            return View(locacaoViewModel);
        }

        // GET: LocacaoController/Create
        public ActionResult Create()
        {
            var clientes = _clienteRepository.GetAll();
            var filmes = _filmeRepository.GetAll();
            var clienteViewModelList = new List<ClienteViewModel>();
            var filmeViewModelList = new List<FilmeViewModel>();

            foreach (var cliente in clientes)
                clienteViewModelList.Add(new ClienteViewModel(cliente));

            foreach(var filme in filmes)
                filmeViewModelList.Add(new FilmeViewModel(filme));

            ViewBag.clienteViewModelList = new MultiSelectList(clienteViewModelList, "ClienteId", "Nome");
            ViewBag.filmeViewModelList = new MultiSelectList(filmeViewModelList, "FilmeId", "TituloFilme");

            return View();
        }

        // POST: LocacaoController/Create
        [HttpPost]
        
        public ActionResult Create(IFormCollection collection)
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

        // GET: LocacaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocacaoController/Edit/5
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

    }
}
