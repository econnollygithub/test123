using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test123.Models;

namespace test123.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns></returns>
        IEnumerable<TestUser> GetUsers();

        /// <summary>
        /// Gets an individual user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        TestUser GetUser(int userId);
    }
}
