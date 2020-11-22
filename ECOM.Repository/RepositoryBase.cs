using ECOM.Data;
using ECOM.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECOM.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        public EcomRepoContext EcomRepoContexts { get; set; }

        public RepositoryBase(EcomRepoContext ecomRepoContext)
        {
            EcomRepoContexts = ecomRepoContext;
        }

        public IQueryable<T> FindAll()
        {
            return EcomRepoContexts.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return EcomRepoContexts.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            EcomRepoContexts.Set<T>().Add(entity);
        }

        
        public void Delete(T entity)
        {
            EcomRepoContexts.Set<T>().Remove(entity);
        }


    }
}
