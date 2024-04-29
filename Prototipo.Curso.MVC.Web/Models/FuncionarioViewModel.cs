using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class FuncionarioViewModel
    {
        public FuncionarioViewModel(Funcionario funcionario = null)
        {
            if (funcionario != null)
            {
                FuncionarioId = funcionario.Id;
                Nome = funcionario.Nome;
                SobreNome = funcionario.SobreNome;
                Email = funcionario.Email;
                Celular = funcionario.Celular;
                TelFixo = funcionario.TelFixo;
                CPF = funcionario.CPF;
                DataNascimento = funcionario.DataNascimento;
                Cidade = funcionario.Cidade;
                Salario = funcionario.Salario;
                DataAdmissao = funcionario.DataAdmissao;
                DataDesligamento = funcionario.DataDesligamento;
                Ativo = funcionario.Ativo;
                EnderecoFuncionarioViewModel = new EnderecoFuncionarioViewModel(funcionario.EnderecoFuncionario);
                CargoViewModel = new CargoViewModel(funcionario.Cargo);
                CargoId = funcionario.CargoId;
            }
        }

        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string TelFixo { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }

        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }

        public bool Ativo { get; set; }

        public EnderecoFuncionarioViewModel EnderecoFuncionarioViewModel { get; set; }

        public CargoViewModel CargoViewModel { get; set; }
        public int CargoId { get; set; }


        public Funcionario ToFuncionario(IFormCollection collection)
        {
            var funcionario = new Funcionario();

            if (!String.IsNullOrEmpty(collection["FuncionarioId"]))
            {
                funcionario.Id = Convert.ToInt32(collection["FuncionarioId"]);
            }

            funcionario.Nome = collection["Nome"];
            funcionario.SobreNome = collection["SobreNome"];
            funcionario.Email = collection["Email"];
            funcionario.Celular = collection["Celular"];
            funcionario.TelFixo = collection["TelFixo"];
            funcionario.CPF = collection["CPF"];
            funcionario.DataNascimento = Convert.ToDateTime(collection["DataNascimento"]);
            funcionario.DataAdmissao = Convert.ToDateTime(collection["DataAdmissao"]);
            funcionario.DataDesligamento = Convert.ToDateTime(collection["DataDesligamento"]);
            funcionario.Ativo = collection["Ativo"].Contains("true") ? true : false;
            funcionario.EnderecoFuncionario = new EnderecoFuncionario()
            {
                Logradouro = collection["enderecoFuncionarioViewModel.Logradouro"].ToString(),
                Bairro = collection["enderecoFuncionarioViewModel.Bairro"].ToString(),
                Numero = collection["enderecoFuncionarioViewModel.Numero"].ToString(),
                CEP = collection["enderecoFuncionarioViewModel.CEP"].ToString(),
                CidadeId = Convert.ToInt32(collection["CidadeId"])
            };

            if (!String.IsNullOrEmpty(collection["enderecoFuncionarioViewModel.EnderecoId"])
                && !String.IsNullOrEmpty(collection["FuncionarioId"]))
            {
                funcionario.EnderecoFuncionario.Id = Convert.ToInt32(collection["enderecoFuncionarioViewModel.EnderecoId"]);
                funcionario.EnderecoFuncionario.FuncionarioId = Convert.ToInt32(collection["FuncionarioId"]);
            }

            return funcionario;
        }

    }
}
