using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class ClienteViewModel
    {
        public ClienteViewModel(Cliente cliente = null)
        {
            if (cliente != null)
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

        public Cliente ToCliente(IFormCollection collection)
        {
            var cliente = new Cliente();

            if (!String.IsNullOrEmpty(collection["ClienteId"]))
            {
                cliente.Id = Convert.ToInt32(collection["ClienteId"]);
            }

            cliente.Nome = collection["Nome"].ToString();
            cliente.SobreNome = collection["SobreNome"].ToString();
            cliente.Email = collection["Email"].ToString();
            cliente.Celular = collection["Celular"].ToString();
            cliente.TelFixo = collection["TelFixo"].ToString();
            cliente.CPF = collection["CPF"].ToString();
            cliente.DataNascimento = Convert.ToDateTime(collection["DataNascimento"]);
            cliente.Endereco = new EnderecoCliente()
            {
                Logradouro = collection["enderecoClienteViewModel.Logradouro"].ToString(),
                Bairro = collection["enderecoClienteViewModel.Bairro"].ToString(),
                Numero = collection["enderecoClienteViewModel.Numero"].ToString(),
                CEP = collection["enderecoClienteViewModel.CEP"].ToString(),
                CidadeId = Convert.ToInt32(collection["CidadeId"])
            };

            if (!String.IsNullOrEmpty(collection["enderecoClienteViewModel.EnderecoId"])
                && !String.IsNullOrEmpty(collection["ClienteId"]))
            {
                cliente.Endereco.Id = Convert.ToInt32(collection["enderecoClienteViewModel.EnderecoId"]);
                cliente.Endereco.ClienteId = Convert.ToInt32(collection["ClienteId"]);
            }

            return cliente;
        }

    }
}
