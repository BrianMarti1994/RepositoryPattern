using ECOM.Data;
using ECOM.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcomAPI.Models;
using System.Linq.Expressions;

namespace ECOM.Repository
{
    public class UserRepository : RepositoryBase<EcomAPI.Models.User>, IUserRepository
    {

        public UserRepository(EcomRepoContext repoContext)
            : base(repoContext)
        {

        }

        //public new void Create(EcomAPI.Models.User entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public new void Delete(EcomAPI.Models.User entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public new IQueryable<EcomAPI.Models.User> FindByCondition(Expression<Func<EcomAPI.Models.User, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}

        IQueryable<EcomAPI.Models.User> IRepositoryBase<EcomAPI.Models.User>.FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
