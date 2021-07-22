using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Users> Get() {
            return Users.GetUser();
        }
        [HttpGet("{name}")]
        public IEnumerable<Users> Get(string name) {
            var users = Users.GetUser();
            return    users.Where(m => m.UserName.Contains(name));
        } 
    }
}
