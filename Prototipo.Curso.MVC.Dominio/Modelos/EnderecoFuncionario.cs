using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class EnderecoFuncionario : EnderecoBase
    {
        public EnderecoFuncionario()
        {
            
        }

        public virtual Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
    }
}
