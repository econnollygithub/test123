using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestPage
    {
        int TestId { get; set; }
        int TestPageNumber { get; set; }
        IEnumerable<TestQuestion> TestQuestions { get; set; }
    }
}
