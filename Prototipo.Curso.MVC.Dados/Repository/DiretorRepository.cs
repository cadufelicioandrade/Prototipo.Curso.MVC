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
    public class DiretorRepository : BaseRepository, IBaseInterface<Diretor>, IDiretorRepository
    {
        public DiretorRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Diretor Create(Diretor entity)
        {
            _context.Diretor.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Diretor GetById(int id)
        {
            return _context.Diretor.FirstOrDefault(d => d.Id == id);
        }

        public List<Diretor> GetAll()
        {
            return _context.Diretor.ToList();
        }

        public Diretor Update(Diretor entity)
        {
            _context.Diretor.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
