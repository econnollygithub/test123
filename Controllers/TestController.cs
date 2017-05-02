using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test123.Models;
using test123.Services;

namespace test123.Controllers
{
    [Route("tests")]
    public class TestController : Controller
    {
        ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public IEnumerable<Test> GetTests()
        {
            var tests = _testService.GetTests();
            return tests;
        }
        
    }
}
