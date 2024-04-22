using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class EnderecoCliente : EnderecoBase
    {
        public EnderecoCliente()
        {
            
        }

        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public virtual Cidade Cidade { get; set; }
        public int CidadeId { get; set; }

    }
}
