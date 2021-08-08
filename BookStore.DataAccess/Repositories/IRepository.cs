using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity, new ()
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        IList<TEntity> GetWithCriteria(Func<TEntity, bool> criteria);
        int Add(TEntity entity);
        int Update(TEntity entity);
        void Delete(int id);
    }
}
