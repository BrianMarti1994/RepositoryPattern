
using EcomAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM.Service.Contract
{
  public  interface IUserService
    {
        List<User> GettAllUser();
    }
}
