using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prototipo.Curso.MVC.Dados.Context;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Dados.Repository
{
    public class CidadeRepository : BaseRepository, IBaseInterface<Cidade>, ICidadeRepository
    {
        public CidadeRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Cidade Create(Cidade entity)
        {
            _context.Cidade.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Cidade GetById(int id)
        {
            return _context.Cidade
                            .Include(c => c.Estado)
                            .FirstOrDefault(c => c.Id == id);
        }

        public List<Cidade> GetAll()
        {
            return _context.Cidade
                        .Include(c => c.Estado)
                        .ToList();
        }

        public Cidade Update(Cidade entity)
        {
            _context.Cidade.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
