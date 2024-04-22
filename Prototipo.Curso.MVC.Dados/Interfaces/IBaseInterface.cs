using Prototipo.Curso.MVC.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dados.Interfaces
{
    public interface IBaseInterface<TEntity> where TEntity : class
    {
        public List<TEntity> GetAll();
        public TEntity GetById(int id);
        public TEntity Create(TEntity entity);
        public TEntity Update(TEntity entity);
    }
}
