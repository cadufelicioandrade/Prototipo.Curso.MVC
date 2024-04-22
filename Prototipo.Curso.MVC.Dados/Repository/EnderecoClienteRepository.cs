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
    public class EnderecoClienteRepository : BaseRepository, IBaseInterface<EnderecoCliente>, IEnderecoClienteRepository
    {
        public EnderecoClienteRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public EnderecoCliente Create(EnderecoCliente entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public EnderecoCliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EnderecoCliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public EnderecoCliente Update(EnderecoCliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
