using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class GeneroViewModel
    {
        public GeneroViewModel(Genero genero = null)
        {
            if (genero != null)
            {
                GeneroId = genero.Id;
                NomeGenero = genero.NomeGenero;
            }

        }

        public int GeneroId { get; set; }
        public string NomeGenero { get; set; }

        public Genero ToGenero(IFormCollection collection)
        {
            var genero = new Genero();

            if (!String.IsNullOrEmpty(collection["GeneroId"]))
            {
                genero.Id = Convert.ToInt32(collection["GeneroId"]);
            }

            genero.NomeGenero = collection["NomeGenero"].ToString();
            return genero;
        }
    }
}
