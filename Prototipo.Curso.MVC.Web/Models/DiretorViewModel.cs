using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class DiretorViewModel
    {
        public DiretorViewModel(Diretor diretor)
        {
            DiretorId = diretor.Id;
            NomeDiretor = diretor.Nome;
        }
        public int DiretorId { get; set; }
        public string NomeDiretor { get; set; }

        public Diretor DiretorViewModelToDiretor()
        {
            var diretor = new Diretor();
            diretor.Id = DiretorId;
            diretor.Nome = NomeDiretor;
            return diretor;
        }
    }
}
