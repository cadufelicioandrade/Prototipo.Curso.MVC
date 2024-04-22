using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Filme : BaseModel
    {
        public Filme()
        {
            
        }

        public string TituloFilme { get; set; }
        public int Ano { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool Disponivel { get; set; }

        public virtual Diretor Diretor { get; set; }
        public int DiretorId { get; set; }

        public virtual Genero Genero { get; set; }
        public int GeneroId { get; set; }

        public virtual List<ItemLocacao> ItemLocacoes { get; set; }
    }
}
