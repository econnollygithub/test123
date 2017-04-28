using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestQuestion
    {
        int QuestionId { get; set; }
        string QuestionText { get; set; }
        IEnumerable<QuestionResponse> QuestionResponses { get; set; }
    }
}
