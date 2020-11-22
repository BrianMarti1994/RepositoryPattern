using ECOM.Repository.Contract;
using ECOM.Service.Contract;
using EcomAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM.Service
{
  public  class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public UserService(IRepositoryWrapper repoWrapper)
        {
            _repositoryWrapper = repoWrapper;
        }

        public List<User> GettAllUser()
        {
            List<User> lstUst = new List<User>();
            var response = _repositoryWrapper.User.FindAll();
            lstUst = response.ToList();
            return lstUst;
        }
    }

    //public List<User> GettAllUser()
    //{
    //    List<User> lst = new List<User>();
    //    //lst =
    //   // var d = _repositoryWrapper.User.FindAll();
    //    return lst;
    //}
}
