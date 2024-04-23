using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class ClienteViewModel
    {
        public ClienteViewModel(Cliente cliente)
        {
            ClienteId = cliente.Id;
            Nome = cliente.Nome;
            SobreNome = cliente.SobreNome;
            Email = cliente.Email;
            Celular = cliente.Celular;
            TelFixo = cliente.TelFixo;
            CPF = cliente.CPF;
            DataNascimento = cliente.DataNascimento;
            Cidade = cliente.Cidade;
            enderecoClienteViewModel = new EnderecoClienteViewModel(cliente.Endereco);
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string TelFixo { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }
        public EnderecoClienteViewModel enderecoClienteViewModel { get; set; } 

    }
}
