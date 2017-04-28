using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test123.Models;
using test123.Services;

namespace test123.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        [HttpGet]
        public IEnumerable<TestUser> GetUsers()
        {
            var userService = new UserService();
            var users = userService.GetUsers();
            return users;
        }

        [HttpGet]
        [Route("{userId}", Name="GetUser")]
        public TestUser GetUser(int userId)
        {
            var userService = new UserService();
            var user = userService.GetUser(userId);
            return user;
        }


    }
}
