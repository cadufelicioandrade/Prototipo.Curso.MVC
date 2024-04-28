using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class DiretorViewModel
    {
        public DiretorViewModel(Diretor diretor = null)
        {
            if (diretor != null)
            {
                DiretorId = diretor.Id;
                NomeDiretor = diretor.NomeDiretor;
            }
        }

        public int DiretorId { get; set; }
        public string NomeDiretor { get; set; }

        public Diretor ToDiretor(IFormCollection collection)
        {
            var diretor = new Diretor();

            if (!String.IsNullOrEmpty(collection["DiretorId"].ToString()))
            {
                diretor.Id = Convert.ToInt32(collection["DiretorId"]);
            }

            diretor.NomeDiretor = collection["NomeDiretor"].ToString();
            return diretor;
        } 
        
    }
}
