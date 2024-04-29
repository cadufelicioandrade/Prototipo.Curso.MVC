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
            return  _context.ItemLocacao
                            .Include(i => i.Locacao)
                            .Include(i => i.Cliente)
                            .Include(i => i.Funcionario)
                            .FirstOrDefault(i => i.Id == id);
        }

        public List<ItemLocacao> GetAll()
        {
            return _context.ItemLocacao
                            .Include(i => i.Locacao)
                            .Include(i => i.Cliente)
                            .Include(i => i.Funcionario)
                            .ToList();
        }

        public ItemLocacao Update(ItemLocacao entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
