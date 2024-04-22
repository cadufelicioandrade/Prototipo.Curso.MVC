using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class GeneroViewModel
    {
        public GeneroViewModel(Genero genero)
        {
            GeneroId = genero.Id;
            NomeGenero = genero.NomeGenero;
        }
        public int GeneroId { get; set; }
        public string NomeGenero { get; set; }

        public Genero GeneroViewModelToGenero()
        {
            var genero = new Genero()
            {
                Id = GeneroId,
                NomeGenero = NomeGenero,
            };
            return genero;
        }
    }
}
