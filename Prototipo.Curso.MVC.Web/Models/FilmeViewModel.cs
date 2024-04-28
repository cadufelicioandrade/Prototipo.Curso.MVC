using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class FilmeViewModel
    {
        public FilmeViewModel(Filme filme = null)
        {
            if (filme != null)
            {
                FilmeId = filme.Id;
                TituloFilme = filme.TituloFilme;
                Ano = filme.Ano;
                ValorDiaria = filme.ValorDiaria;
                Disponivel = filme.Disponivel;
                diretorViewModel = new DiretorViewModel(filme.Diretor);
                DiretorId = filme.DiretorId;
                generoViewModel = new GeneroViewModel(filme.Genero);
                GeneroId = filme.GeneroId;
            }
        }

        public int FilmeId { get; set; }
        public string TituloFilme { get; set; }
        public int Ano { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool Disponivel { get; set; }

        public virtual DiretorViewModel diretorViewModel { get; set; }
        public int DiretorId { get; set; }

        public GeneroViewModel generoViewModel { get; set; }
        public int GeneroId { get; set; }

        public Filme ToFilme(IFormCollection collection)
        {
            var filme = new Filme();

            if (!String.IsNullOrEmpty(collection["FilmeId"].ToString()))
            {
                filme.Id = Convert.ToInt32(collection["FilmeId"]);
            }

            filme.TituloFilme = collection["TituloFilme"].ToString();
            filme.Ano = Convert.ToInt32(collection["Ano"]);
            filme.ValorDiaria = Convert.ToDecimal(collection["ValorDiaria"]);
            filme.Disponivel = collection["Disponivel"].ToString().Contains("true") ? true : false;
            filme.DiretorId = Convert.ToInt32(collection["DiretorId"]);
            filme.GeneroId = Convert.ToInt32(collection["GeneroId"]);

            return filme;
        }
    }
}
