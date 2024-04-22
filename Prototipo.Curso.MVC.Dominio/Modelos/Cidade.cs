using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Cidade : BaseModel
    {
        public Cidade()
        {
            
        }

        public string NomeCidade { get; set; }
        public virtual List<EnderecoBase> Enderecos { get; set; }

        public virtual Estado Estado { get; set; }
        public int EstadoId { get; set; }

    }
}
