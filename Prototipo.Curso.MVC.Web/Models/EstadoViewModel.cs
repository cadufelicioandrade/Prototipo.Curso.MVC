using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class EstadoViewModel
    {
        public EstadoViewModel(Estado estado)
        {
            EstadoId = estado.Id;
            NomeEstado = estado.NomeEstado;
        }

        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }

        public Estado EstadoViewModelToEstado()
        {
            var estado = new Estado();
            estado.Id = EstadoId;
            estado.NomeEstado = NomeEstado;
            return estado;
        }
    }
}
