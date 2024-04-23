using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;
using Prototipo.Curso.MVC.Web.Models;

namespace Prototipo.Curso.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public ClienteController(IClienteRepository clienteRepository, 
                                ICidadeRepository cidadeRepository)
        {
            _clienteRepository = clienteRepository;
            _cidadeRepository = cidadeRepository;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            var clientes = _clienteRepository.GetAll();
            var clienteViewModelList = new List<ClienteViewModel>();

            foreach (var cliente in clientes)
                clienteViewModelList.Add(new ClienteViewModel(cliente));

            return View(clienteViewModelList);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            var clienteViewModel = new ClienteViewModel(cliente);

            return View(clienteViewModel);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            var cidades = _cidadeRepository.GetAll();
            var cidadeViewModelList = new List<CidadeViewModel>();

            foreach (var cidade in cidades)
                cidadeViewModelList.Add(new CidadeViewModel(cidade));

            ViewBag.cidadeViewModelList = new MultiSelectList(cidadeViewModelList, "CidadeId", "NomeCidade");

            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var cidade = _cidadeRepository.GetById(Convert.ToInt32(collection["CidadeId"]));
                var cliente = new Cliente()
                {
                    Nome = collection["Nome"].ToString(),
                    SobreNome = collection["SobreNome"].ToString(),
                    Email = collection["Email"].ToString(),
                    Celular = collection["Celular"].ToString(),
                    TelFixo = collection["TelFixo"].ToString(),
                    CPF = collection["CPF"].ToString(),
                    DataNascimento = Convert.ToDateTime(collection["DataNascimento"]),
                    Cidade = cidade.NomeCidade,
                    Endereco = new EnderecoCliente()
                    {
                        Logradouro = collection["enderecoClienteViewModel.Logradouro"].ToString(),
                        Bairro = collection["enderecoClienteViewModel.Bairro"].ToString(),
                        Numero = collection["enderecoClienteViewModel.Numero"].ToString(),
                        CEP = collection["enderecoClienteViewModel.CEP"].ToString(),
                        CidadeId = Convert.ToInt32(collection["CidadeId"])
                    }
                };

                _clienteRepository.Create(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var cliene = _clienteRepository.GetById(id);
            var clienteViewModel = new ClienteViewModel(cliene);
            var cidades = _cidadeRepository.GetAll();
            var cidadeViewModelList = new List<CidadeViewModel>();

            foreach (var cidade in cidades)
                cidadeViewModelList.Add(new CidadeViewModel(cidade));

            ViewBag.cidadeViewModelList = new MultiSelectList(cidadeViewModelList, "CidadeId", "NomeCidade");

            return View(clienteViewModel);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var cidade = _cidadeRepository.GetById(Convert.ToInt32(collection["CidadeId"]));
                var cliente = new Cliente()
                {
                    Nome = collection["Nome"].ToString(),
                    SobreNome = collection["SobreNome"].ToString(),
                    Email = collection["Email"].ToString(),
                    Celular = collection["Celular"].ToString(),
                    TelFixo = collection["TelFixo"].ToString(),
                    CPF = collection["CPF"].ToString(),
                    DataNascimento = Convert.ToDateTime(collection["DataNascimento"]),
                    Cidade = cidade.NomeCidade,
                    Endereco = new EnderecoCliente()
                    {
                        Logradouro = collection["enderecoClienteViewModel.Logradouro"].ToString(),
                        Bairro = collection["enderecoClienteViewModel.Bairro"].ToString(),
                        Numero = collection["enderecoClienteViewModel.Numero"].ToString(),
                        CEP = collection["enderecoClienteViewModel.CEP"].ToString(),
                        CidadeId = Convert.ToInt32(collection["CidadeId"])
                    }
                };

                _clienteRepository.Update(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
