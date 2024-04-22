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
    public class FilmeRepository : BaseRepository, IBaseInterface<Filme>, IFilmeRepository
    {
        public FilmeRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Filme Create(Filme entity)
        {
            _context.Filme.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Filme GetById(int id)
        {
            return _context.Filme.FirstOrDefault(f => f.Id == id);
        }

        public List<Filme> GetAll()
        {
            return _context.Filme.ToList();
        }

        public Filme Update(Filme entity)
        {
            _context.Filme.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
