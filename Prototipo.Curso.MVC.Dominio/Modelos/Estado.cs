using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Estado : BaseModel
    {
        public Estado()
        {
            
        }

        public string NomeEstado { get; set; }
        public virtual List<Cidade> Cidades { get; set; }
    }
}
