using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class FilmeViewModel
    {
        public FilmeViewModel(Filme filme)
        {
            FilmeId = filme.Id;
            TituloFilme = filme.TituloFilme;
            Ano = filme.Ano;
            ValorDiaria = filme.ValorDiaria;
            Disponivel = filme.Disponivel;
            diretorViewModel = new DiretorViewModel(filme.Diretor);
            generoViewModel = new GeneroViewModel(filme.Genero);
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

        public Filme FilmeViewModelToFilme()
        {
            var filme = new Filme();
            filme.Id = FilmeId;
            filme.TituloFilme = TituloFilme;
            filme.Ano = Ano;
            filme.ValorDiaria = ValorDiaria;
            filme.Diretor = new Diretor()
            {
                Id = DiretorId,
                Nome = diretorViewModel.NomeDiretor
            };
            filme.Genero = new Genero()
            {
                Id = generoViewModel.GeneroId,
                NomeGenero = generoViewModel.NomeGenero
            };

            return filme;
        }
    }
}
