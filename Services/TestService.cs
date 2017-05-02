using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test123.Models;

namespace test123.Services
{
    public class TestService : ITestService
    {
        /// <summary>
        /// Given a test page number and test id,
        /// gets the test questions for that page
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="testPageNumber"></param>
        /// <returns></returns>
        public IEnumerable<TestQuestion> GetQuestionsForTestPage(int testId, int testPageNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a TestQuestion Id, gets all the responses for the 
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public IEnumerable<QuestionResponse> GetResponsesForTestQuestion(int questionId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all or a selected test page for the test
        /// indicated.
        /// </summary>
        /// <param name="testName">name of test</param>
        /// <param name="pageNumber">if 0 get all</param>
        /// <returns></returns>
        public IEnumerable<TestPage> GetTestAsTestPages(string testName, int pageNumber = 0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all the Test metadata information; test pages
        /// are not populated
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Test> GetTests()
        {
            var tests = new List<Test>()
            {
                new Test
                {
                    TestId = 1,
                    TestDifficulty = 2,
                    TestName = "Anatomy",
                    TestType = new TestType
                    {
                        TestTypeId = 1,
                        TestTypeName = "Medical"
                    },
                },
                new Test
                {
                    TestId = 2,
                    TestDifficulty = 3,
                    TestName = "Biochemistry",
                    TestType = new TestType
                    {
                        TestTypeId = 1,
                        TestTypeName = "Medical"
                    }
                },
                new Test
                {
                    TestId = 3,
                    TestDifficulty = 4,
                    TestName = "Immunology",
                    TestType = new TestType
                    {
                        TestTypeId = 1,
                        TestTypeName = "Medical"
                    }
                },
            };
            return tests;
        }
    }
}
