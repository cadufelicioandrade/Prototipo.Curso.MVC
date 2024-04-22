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
    public class ItemLocacaoRepository : BaseRepository, IBaseInterface<ItemLocacao>, IItemLocacaoRepository
    {
        public ItemLocacaoRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public ItemLocacao Create(ItemLocacao entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public ItemLocacao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemLocacao> GetAll()
        {
            throw new NotImplementedException();
        }

        public ItemLocacao Update(ItemLocacao entity)
        {
            throw new NotImplementedException();
        }
    }
}
