using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestUser
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        IEnumerable<TestResult> CurrentResults { get; set; }

    }
}
