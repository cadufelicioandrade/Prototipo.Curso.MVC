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
    public class GeneroRepository : BaseRepository, IBaseInterface<Genero>, IGeneroRepository
    {
        public GeneroRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Genero Create(Genero entity)
        {
            _context.Genero.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Genero GetById(int id)
        {
            return  _context.Genero.FirstOrDefault(g => g.Id == id);
        }

        public List<Genero> GetAll()
        {
            return _context.Genero.ToList();
        }

        public Genero Update(Genero entity)
        {
            _context.Genero.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
