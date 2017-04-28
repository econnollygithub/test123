using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestPage
    {
        public int TestId { get; set; }
        public int TestPageNumber { get; set; }
        public IEnumerable<TestQuestion> TestQuestions { get; set; }
    }
}
