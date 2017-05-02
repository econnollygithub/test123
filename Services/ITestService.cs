using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test123.Models;

namespace test123.Services
{
    public interface ITestService
    {
        /// <summary>
        /// Gets all the Test metadata information for all tests; test pages
        /// are not populated
        /// </summary>
        /// <returns></returns>
        IEnumerable<Test> GetTests();

        /// <summary>
        /// Gets all or a selected test page for the test
        /// indicated.
        /// </summary>
        /// <param name="testName">name of test</param>
        /// <param name="pageNumber">if 0 or null get all, else get the pages requested</param>
        /// <returns></returns>
        IEnumerable<TestPage> GetTestAsTestPages(string testName, int pageNumber = 0);

        /// <summary>
        /// Given a test page number and test id,
        /// gets the test questions for that page
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="testPageNumber"></param>
        /// <returns></returns>
        IEnumerable<TestQuestion> GetQuestionsForTestPage(int testId, int testPageNumber);

        /// <summary>
        /// Given a TestQuestion Id, gets all the responses for the 
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        IEnumerable<QuestionResponse> GetResponsesForTestQuestion(int questionId);
    }
}
