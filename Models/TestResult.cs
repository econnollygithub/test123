using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestResult
    {
        public string TestName {get; set;}
        public int TestId {get; set;}
        public int LastCompletedQuestion { get; set;}
        public int UserId { get; set;}
        public int NumberRight { get; set;}
        public int NumberWrong { get; set;}
        public int PercentRight { get; set;}
        public int AllowedTime { get; set;}
    }
}
