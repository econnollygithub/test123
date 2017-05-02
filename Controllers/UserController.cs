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
        IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<TestUser> GetUsers()
        {
            var users = _userService.GetUsers();
            return users;
        }

        [HttpGet]
        [Route("{userId}", Name="GetUser")]
        public TestUser GetUser(int userId)
        {
            var user = _userService.GetUser(userId);
            return user;
        }


    }
}
