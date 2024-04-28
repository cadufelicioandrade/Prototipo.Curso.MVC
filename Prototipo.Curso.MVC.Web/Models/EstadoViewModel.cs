using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class EstadoViewModel
    {
        public EstadoViewModel(Estado estado = null)
        {
            if (estado != null)
            {
                EstadoId = estado.Id;
                NomeEstado = estado.NomeEstado;
            }
        }

        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }

        public Estado ToEstado(IFormCollection collection)
        {
            var estado = new Estado();

            if (!String.IsNullOrEmpty(collection["EstadoId"].ToString()))
            {
                estado.Id = Convert.ToInt32(collection["EstadoId"]);
            }

            estado.NomeEstado = collection["NomeEstado"].ToString();

            return estado;
        }
    }
}
