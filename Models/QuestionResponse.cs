using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class QuestionResponse
    {
        int QuestionId { get; set; }
        string ResponseText { get; set; }
        ResponseTypeEnum ResponseType { get; set; }

    }
}
