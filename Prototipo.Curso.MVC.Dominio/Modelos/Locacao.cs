using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Locacao : BaseModel
    {
        public Locacao()
        {

        }
        public decimal ValorTotal { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal MultaAtraso { get; set; }

        public virtual List<ItemLocacao> ItemLocacoes { get; set; }
    }
}
