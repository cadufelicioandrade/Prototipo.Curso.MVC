using Prototipo.Curso.MVC.Dominio.Modelos;
using System.Diagnostics.CodeAnalysis;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class CargoViewModel
    {
        public CargoViewModel(Cargo cargo = null)
        {
            if (cargo != null)
            {
                CargoId = cargo.Id;
                Descricao = cargo.Descricao;
                Administrador = cargo.Administrador;
            }
        }

        public int CargoId { get; set; }
        public string Descricao { get; set; }
        public bool Administrador { get; set; }

        public Cargo ToCargo(IFormCollection collection)
        {
            var cargo = new Cargo();

            if (!String.IsNullOrEmpty(collection["CargoId"]))
            {
                cargo.Id = Convert.ToInt32(collection["CargoId"]);
            }

            cargo.Descricao = collection["Deescricao"];
            cargo.Administrador = collection["Administrador"].Contains("true") ? true : false;

            return cargo;
        }
    }
}
