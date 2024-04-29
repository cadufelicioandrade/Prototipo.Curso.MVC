using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class EnderecoClienteViewModel
    {
        public EnderecoClienteViewModel(EnderecoCliente enderecoCliente)
        {
            EnderecoId = enderecoCliente.Id;
            Logradouro = enderecoCliente.Logradouro;
            Bairro = enderecoCliente.Bairro;
            CEP = enderecoCliente.CEP;
            Numero = enderecoCliente.Numero;
            cidadeViewModel = new CidadeViewModel(enderecoCliente.Cidade);
        }

        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public CidadeViewModel cidadeViewModel { get; set; }


    }
}
