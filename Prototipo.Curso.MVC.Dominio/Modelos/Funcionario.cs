using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Funcionario : Pessoa
    {
        public Funcionario()
        {

        }

        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }

        public bool Ativo { get; set; }


        public virtual EnderecoFuncionario EnderecoFuncionario { get; set; }
        public virtual List<ItemLocacao> ItemLocacoes { get; set; }

        public virtual Cargo Cargo { get; set; }
        public int CargoId { get; set; }
    }
}
