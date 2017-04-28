using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int TestDifficulty { get; set; }
        public TestType TestType { get; set; }
        public IEnumerable<TestPage> TestPages { get; set; }

    }
}
