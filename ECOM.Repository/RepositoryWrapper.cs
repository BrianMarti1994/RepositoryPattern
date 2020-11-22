using ECOM.Data;
using ECOM.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {


        private EcomRepoContext _ecomRepoContext;
        public RepositoryWrapper(EcomRepoContext ecomRepoContext)
        {
            _ecomRepoContext = ecomRepoContext;
        }


        private IUserRepository _user;
        private IItemRepository _item;

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_ecomRepoContext);
                }

                return _user;

            }

        }
        public IItemRepository Item
        {
            get
            {
                if (_item == null)
                {
                    _item = new ItemRepository(_ecomRepoContext);
                }

                return _item;

            }

        }



        public void Save()
        {
            _ecomRepoContext.SaveChanges();

        }


    }
}
