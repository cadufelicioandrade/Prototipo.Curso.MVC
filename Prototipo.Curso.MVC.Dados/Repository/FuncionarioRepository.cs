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
    public class FuncionarioRepository : BaseRepository, IBaseInterface<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Funcionario Create(Funcionario entity)
        {
            _context.Funcionario.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Funcionario GetById(int id)
        {
            return  _context.Funcionario.FirstOrDefault(x => x.Id == id);
        }

        public List<Funcionario> GetAll()
        {
            return _context.Funcionario.ToList();
        }

        public bool Inativar(int id)
        {
            var funcionario = this.GetById(id);
            funcionario.Ativo = false;
            _context.Funcionario.Update(funcionario);
            var resultado =_context.SaveChanges();

            return resultado > 0;
        }

        public Funcionario Update(Funcionario entity)
        {
            _context.Funcionario.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
