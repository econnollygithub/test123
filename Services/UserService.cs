using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test123.Models;

namespace test123.Services
{
    public class UserService : IUserService
    {
        public IEnumerable<TestUser> GetUsers()
        {
            var users = new List<TestUser>
            {
                new TestUser()
                {
                    UserId = 1,
                    FirstName = "David",
                    LastName = "Joyce",
                },
                new TestUser()
                {
                    UserId = 2,
                    FirstName = "Fred",
                    LastName = "Forti",
                },
                new TestUser()
                {
                    UserId = 3,
                    FirstName = "Brigid",
                    LastName = "Daly",
                }
            };

            return users;
        }

        public TestUser GetUser(int userId)
        {
            var users = GetUsers();
            var user = users.FirstOrDefault(a => a.UserId == userId);

            return user;
        }
    }
}
