using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class QuestionResponse
    {
        public int QuestionId { get; set; }
        public string ResponseText { get; set; }
        public ResponseTypeEnum ResponseType { get; set; }

    }
}
