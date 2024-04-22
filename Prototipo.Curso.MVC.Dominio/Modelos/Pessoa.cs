using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dominio.Modelos
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string TelFixo { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
