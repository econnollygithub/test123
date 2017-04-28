using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class Test
    {
        int TestId { get; set; }
        string TestName { get; set; }
        int TestDifficulty { get; set; }
        TestType TestType { get; set; }
        IEnumerable<TestPage> TestPages { get; set; }

    }
}
