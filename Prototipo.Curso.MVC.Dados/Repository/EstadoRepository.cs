using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo.Curso.MVC.Dados.Context;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Dados.Repository
{
    public class EstadoRepository : BaseRepository, IBaseInterface<Estado>, IEstadoRepository
    {
        public EstadoRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Estado Create(Estado entity)
        {
            _context.Estado.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Estado GetById(int id)
        {
            return _context.Estado.FirstOrDefault(e => e.Id == id);
        }

        public List<Estado> GetAll()
        {
            return _context.Estado.ToList();
        }

        public Estado Update(Estado entity)
        {
            _context.Estado.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
