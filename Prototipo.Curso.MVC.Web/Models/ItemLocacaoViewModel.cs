using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Web.Models
{
    public class ItemLocacaoViewModel
    {
        public ItemLocacaoViewModel(ItemLocacao itemLocacao = null)
        {
            if (itemLocacao != null)
            {
                ItemLocacaoId = itemLocacao.Id;
                Diarias = itemLocacao.Diarias;
                ValorDiaria = itemLocacao.ValorDiaria;
                ClienteViewModel = new ClienteViewModel(itemLocacao.Cliente);
                ClienteId = itemLocacao.ClienteId;
                FilmeViewModel = new FilmeViewModel(itemLocacao.Filme);
                FilmeId = itemLocacao.FilmeId;
                FuncionarioViewModel = new FuncionarioViewModel(itemLocacao.Funcionario);
                FuncionarioId = itemLocacao.FuncionarioId;
                LocacaoViewModel = new LocacaoViewModel(itemLocacao.Locacao);
                LocacaoId = itemLocacao.LocacaoId;
            }
        }

        public int ItemLocacaoId { get; set; }
        public int Diarias { get; set; }
        public decimal ValorDiaria { get; set; }

        public ClienteViewModel ClienteViewModel { get; set; }
        public int ClienteId { get; set; }

        public FilmeViewModel FilmeViewModel { get; set; }
        public int FilmeId { get; set; }

        public FuncionarioViewModel FuncionarioViewModel { get; set; }
        public int FuncionarioId { get; set; }

        public LocacaoViewModel LocacaoViewModel { get; set; }
        public int LocacaoId { get; set; }

    }
}
