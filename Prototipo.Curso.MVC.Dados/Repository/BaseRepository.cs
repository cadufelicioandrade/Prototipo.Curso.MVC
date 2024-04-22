using Prototipo.Curso.MVC.Dados.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dados.Repository
{
    public class BaseRepository
    {
        public LocadoraContext _context;
        public BaseRepository(LocadoraContext locadoraContext)
        {
            _context = locadoraContext;    
        }
    }
}
