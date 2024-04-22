using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class ItemLocacao : BaseModel
    {
        public ItemLocacao()
        {
            
        }

        public int Diarias { get; set; }
        public decimal ValorDiaria { get; set; }

        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public virtual Filme Filme { get; set; }
        public int FilmeId { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }

        public virtual List<Locacao> Locacoes { get; set; }
    }
}
