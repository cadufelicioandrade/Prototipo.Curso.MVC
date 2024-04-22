using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class CidadeViewModel
    {
        public CidadeViewModel(Cidade cidade)
        {
            CidadeId = cidade.Id;
            NomeCidade = cidade.NomeCidade;
            EstadoViewModel = new EstadoViewModel(cidade.Estado);
            EstadoId = cidade.EstadoId;
        }

        public int CidadeId { get; set; }
        public string NomeCidade { get; set; }
        public virtual EstadoViewModel EstadoViewModel { get; set; }
        public int EstadoId { get; set; }

        public Cidade CidadeViewModelToCidade()
        {
            var cidade = new Cidade();
            cidade.Id = CidadeId;
            cidade.NomeCidade = NomeCidade;
            cidade.Estado = new Estado()
            {
                Id = EstadoId,
                NomeEstado = this.EstadoViewModel.NomeEstado,
            };

            return cidade;
        }

    }
}
