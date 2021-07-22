using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public static List<Users> GetUser()
        {
            return new List<Users>() {
        new Users{ Id=1,UserName= "Ace",Age=18},
        new Users{ Id=2,UserName= "Taro",Age=18},
        new Users{ Id=3,UserName= "Leo",Age=18},
        new Users{ Id=4,UserName= "Astra",Age=18},
        new Users{ Id=5,UserName= "80",Age=18},
        new Users{ Id=6,UserName= "Yullian",Age=18},
        };
        }
    }
}
