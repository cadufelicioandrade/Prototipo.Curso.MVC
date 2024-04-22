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
    public class EnderecoFuncionarioRepository : BaseRepository, IBaseInterface<EnderecoFuncionario>, IEnderecoFuncionarioRepository
    {
        public EnderecoFuncionarioRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public EnderecoFuncionario Create(EnderecoFuncionario entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public EnderecoFuncionario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EnderecoFuncionario> GetAll()
        {
            throw new NotImplementedException();
        }

        public EnderecoFuncionario Update(EnderecoFuncionario entity)
        {
            throw new NotImplementedException();
        }
    }
}
