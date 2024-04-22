using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Cargo : BaseModel
    {
        public Cargo()
        {
        }

        public string Descricao { get; set; }
        public bool Administrador { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}
