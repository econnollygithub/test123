using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<QuestionResponse> QuestionResponses { get; set; }
    }
}
