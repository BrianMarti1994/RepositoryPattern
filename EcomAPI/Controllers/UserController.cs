
using ECOM.Service.Contract;
using EcomAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcomAPI.Controllers
{
    public class UserController : ApiController
    {
        public IUserService Service { get; private set; }

        public UserController(IUserService service)
        {
            this.Service = service;
        }

        [HttpGet]
        public List<User> GetAllUser()
        {

            return Service.GettAllUser();


        }
    }
}
