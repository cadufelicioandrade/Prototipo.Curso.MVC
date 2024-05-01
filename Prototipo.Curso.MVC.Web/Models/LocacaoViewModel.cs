using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class LocacaoViewModel
    {
        public LocacaoViewModel(Locacao locacao = null)
        {
            if(locacao != null)
            {
                LocacaoId = locacao.Id;
                ValorTotal = locacao.ValorTotal;
                DataLocacao = locacao.DataLocacao;
                DataDevolucao = locacao.DataDevolucao;
                ItemLocacoesViewModel = new List<ItemLocacaoViewModel>();
                foreach (var item in locacao.ItemLocacoes)
                    ItemLocacoesViewModel.Add(new ItemLocacaoViewModel(item));
            }
            
        }

        public int LocacaoId { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal MultaAtraso { get; set; }
        public int ClienteId { get; set; }
        public int FilmeId { get; set; }
        public virtual List<ItemLocacaoViewModel> ItemLocacoesViewModel { get; set; }

        public Locacao ToItemLocacao(IFormCollection collection)
        {
            var locacao = new Locacao();

            if (String.IsNullOrEmpty(collection["ItemLocacaoId"]))
            {
                locacao.Id = Convert.ToInt32(collection["ItemLocacaoId"]);
            }

            locacao.ValorTotal = Convert.ToDecimal(collection["ValorTotal"]);
            locacao.DataLocacao = Convert.ToDateTime(collection["DataLocacao"]);
            locacao.DataDevolucao = Convert.ToDateTime(collection["DataDevolucao"]);
            locacao.MultaAtraso = Convert.ToDecimal(collection["MultaAtraso"]);
            locacao.ItemLocacoes = new List<ItemLocacao>();

            //var locacoesViewModelList = (List<ItemLocacaoViewModel>)collection["ItemLocacoesViewModel"]
            

            return locacao;
        }
    }
}
