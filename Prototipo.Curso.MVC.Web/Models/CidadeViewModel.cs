using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class CidadeViewModel
    {
        public CidadeViewModel(Cidade cidade = null)
        {
            if (cidade != null)
            {
                CidadeId = cidade.Id;
                NomeCidade = cidade.NomeCidade;
                EstadoViewModel = new EstadoViewModel(cidade.Estado);
                EstadoId = cidade.EstadoId;
            }
        }

        public int CidadeId { get; set; }
        public string NomeCidade { get; set; }
        public virtual EstadoViewModel EstadoViewModel { get; set; }
        public int EstadoId { get; set; }

        public Cidade ToCidade(IFormCollection colletcion)
        {
            var cidade = new Cidade();

            if (!String.IsNullOrEmpty(colletcion["CidadeId"].ToString()))
            {
                cidade.Id = Convert.ToInt32(colletcion["CidadeId"]);
            }

            cidade.NomeCidade = colletcion["NomeCidade"].ToString();
            cidade.EstadoId = Convert.ToInt32(colletcion["EstadoId"]);

            return cidade;
        }

    }
}
