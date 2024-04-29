using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class EnderecoFuncionarioViewModel
    {
        public EnderecoFuncionarioViewModel(EnderecoFuncionario enderecoFuncionario)
        {
            EnderecoId = enderecoFuncionario.Id;
            Logradouro = enderecoFuncionario.Logradouro;
            Bairro = enderecoFuncionario.Bairro;
            CEP = enderecoFuncionario.CEP;
            Numero = enderecoFuncionario.Numero;
            cidadeViewModel = new CidadeViewModel(enderecoFuncionario.Cidade);
        }

        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public CidadeViewModel cidadeViewModel { get; set; }
    }
}
