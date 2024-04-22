using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Genero : BaseModel
    {
        public Genero()
        {
        }

        public string NomeGenero { get; set; }
        public virtual List<Filme> Filmes { get; set; }

    }
}
