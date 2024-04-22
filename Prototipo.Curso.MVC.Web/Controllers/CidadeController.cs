﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class CidadeController : Controller
    {
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IEstadoRepository _estadoRepository;

        public CidadeController(ICidadeRepository cidadeRepository, 
                                IEstadoRepository estadoRepository)
        {
            _cidadeRepository = cidadeRepository;
            _estadoRepository = estadoRepository;
        }

        // GET: CidadeController
        public ActionResult Index()
        {
            var cidades = _cidadeRepository.GetAll();
            var cidadeViewModelList = new List<CidadeViewModel>();
            foreach (var cidade in cidades)
                cidadeViewModelList.Add(new CidadeViewModel(cidade));

            return View(cidadeViewModelList);
        }

        // GET: CidadeController/Details/5
        public ActionResult Details(int id)
        {
            var cidade = _cidadeRepository.GetById(id);
            var cidadeViewModel = new CidadeViewModel(cidade);
            return View(cidadeViewModel);
        }

        // GET: CidadeController/Create
        public ActionResult Create()
        {
            var estados = _estadoRepository.GetAll();
            var estadoViewModelList = new List<EstadoViewModel>();

            foreach (var estado in estados)
                estadoViewModelList.Add(new EstadoViewModel(estado));

            ViewBag.estadoViewModelList = new MultiSelectList(estadoViewModelList, "EstadoId", "NomeEstado");

            return View();
        }

        // POST: CidadeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var cidade = new Cidade()
                {
                    NomeCidade = collection["NomeCidade"].ToString(),
                    EstadoId = Convert.ToInt32(collection["EstadoId"])
                };

                var newCidade = _cidadeRepository.Create(cidade);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CidadeController/Edit/5
        public ActionResult Edit(int id)
        {
            var cidade = _cidadeRepository.GetById(id);
            var cidadeViewModel = new CidadeViewModel(cidade);

            var estados = _estadoRepository.GetAll();
            var estadoViewModelList = new List<EstadoViewModel>();

            foreach (var estado in estados)
                estadoViewModelList.Add(new EstadoViewModel(estado));

            ViewBag.estadoViewModelList = new MultiSelectList(estadoViewModelList, "EstadoId", "NomeEstado");

            return View(cidadeViewModel);
        }

        // POST: CidadeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var cidade = new Cidade()
                {
                    Id = Convert.ToInt32(collection["CidadeId"]),
                    EstadoId = Convert.ToInt32(collection["EstadoId"]),
                    NomeCidade = collection["NomeCidade"].ToString()
                };

                _cidadeRepository.Update(cidade);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
