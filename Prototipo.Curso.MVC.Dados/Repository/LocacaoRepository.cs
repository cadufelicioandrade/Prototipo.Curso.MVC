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
    public class LocacaoRepository : BaseRepository, IBaseInterface<Locacao>, ILocacaoRepository
    {
        public LocacaoRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Locacao Create(Locacao entity)
        {
            _context.Locacao.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Locacao GetById(int id)
        {
            return _context.Locacao
                        .Include(l => l.ItemLocacoes)
                        .Include("ItemLocacoes.Cliente")
                        .Include("ItemLocacoes.Filme")
                        .Include("ItemLocacoes.Funcionario")
                        .FirstOrDefault(l => l.Id == id);
        }

        public List<Locacao> GetAll()
        {
            return _context.Locacao
                            .Include(l => l.ItemLocacoes)
                            .Include("ItemLocacoes.Cliente")
                            .Include("ItemLocacoes.Filme")
                            .Include("ItemLocacoes.Funcionario")
                            .ToList();
        }

        public Locacao Update(Locacao entity)
        {
            _context.Locacao.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
