using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test123.Models
{
    public class TestResult
    {
        string TestName {get; set;}
        int TestId {get; set;}
        int LastCompletedQuestion { get; set;}
        int UserId { get; set;}
        int NumberRight { get; set;}
        int NumberWrong { get; set;}
        int PercentRight { get; set;}
        int AllowedTime { get; set;}
    }
}
