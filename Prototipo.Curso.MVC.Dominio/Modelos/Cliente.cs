using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {

        }

        public virtual EnderecoCliente Endereco { get; set; }
        public virtual List<ItemLocacao> ItemLocacoes { get; set; }
    }
}
