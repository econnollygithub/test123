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
            var questions = new List<TestQuestion>
            {
                new TestQuestion
                {
                    QuestionId = 1,
                    QuestionText = "A 16-year-old boy is admitted to the emergency department because of a knife wound to the left side of his chest. An x-ray of the chest shows an air-fluid level in the left side of the chest, partial collapse of the left lung, and elevation of the stomach bubble. The mediastinum is in the midline. Which of the following is the most likely diagnosis?  ",
                    QuestionResponses = GetResponsesForTestQuestion(1)
                },
                new TestQuestion
                {
                    QuestionId = 2,
                    QuestionText = "An 84-year-old woman who resides in an assisted living facility is brought to the emergency department because of fever and cough for 1 week. The cough has been productive of foul-smelling, yellow-green sputum for 24 hours. She has a 2-year history of dementia, Alzheimer type. Her temperature is 38.5°C (101.3°F), pulse is 80/min, respirations are 20/min, and blood pressure is 116/66 mm Hg. Coarse inspiratory crackles are heard over the right lung field. Laboratory studies show a leukocyte count of 13,500/mm3 (72% segmented neutrophils, 8% bands, 1% eosinophils, 16% lymphocytes, and 3% monocytes). A CT scan shows a cavitary lesion in the superior segment of the right lower lobe. The lesion has a thick wall and an irregular peripheral margin; there is no displacement of the adjacent bronchovascular bundle. Which of the following is the most likely cause of the lung lesion in this patient?  ",
                    QuestionResponses = GetResponsesForTestQuestion(2)
                }
            };
            var thisPageQuestions = questions.Where(a => a.TestId.Equals(testId));
            return questions;
        }

        /// <summary>
        /// Given a TestQuestion Id, gets all the responses for the 
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public IEnumerable<QuestionResponse> GetResponsesForTestQuestion(int questionId)
        {
            var responses = new List<QuestionResponse>
            {
                new QuestionResponse
                {
                    ResponseText = "Hemopneumothorax, not under tension",
                    ResponseType = ResponseTypeEnum.Correct,
                    QuestionId = 1
                },
                new QuestionResponse
                {
                    ResponseText = "Hemothorax, not under tension",
                    ResponseType = ResponseTypeEnum.FarOff,
                    QuestionId = 1
                },
                new QuestionResponse
                {
                    ResponseText = "Pneumothorax, not under tension",
                    ResponseType = ResponseTypeEnum.MediumFarOff,
                    QuestionId = 1
                },
                new QuestionResponse
                {
                    ResponseText = "Tension hemopneumothorax",
                    ResponseType = ResponseTypeEnum.Close,
                    QuestionId = 1
                },
                new QuestionResponse
                {
                    ResponseText = "Tension hemothorax ",
                    ResponseType = ResponseTypeEnum.MediumFarOff,
                    QuestionId = 1
                },
                new QuestionResponse
                {
                    ResponseText = "Tension pneumothorax",
                    ResponseType = ResponseTypeEnum.MediumFarOff,
                    QuestionId = 1
                },
                new QuestionResponse
                {
                    ResponseText = "Antecedent viral pneumonia",
                    ResponseType = ResponseTypeEnum.Correct,
                    QuestionId = 2
                },
                new QuestionResponse
                {
                    ResponseText = "Aspiration of gastric contents",
                    ResponseType = ResponseTypeEnum.Correct,
                    QuestionId = 2
                },
                new QuestionResponse
                {
                    ResponseText = "Bronchial obstruction by metastatic carcinoma",
                    ResponseType = ResponseTypeEnum.MediumFarOff,
                    QuestionId = 2
                },
                new QuestionResponse
                {
                    ResponseText = "Lung infarction secondary to arterial thrombosis",
                    ResponseType = ResponseTypeEnum.Close,
                    QuestionId = 2
                },
                new QuestionResponse
                {
                    ResponseText = "Primary carcinoma of the lung",
                    ResponseType = ResponseTypeEnum.FarOff,
                    QuestionId = 2
                },
                new QuestionResponse
                {
                    ResponseText = "Secondary infection of a congenital lung cyst",
                    ResponseType = ResponseTypeEnum.MediumFarOff,
                    QuestionId = 2
                },
                new QuestionResponse
                {
                    ResponseText = "Septic embolism from an extrapulmonary site",
                    ResponseType = ResponseTypeEnum.MediumFarOff,
                    QuestionId = 2
                }
            };

            var thisQuestionResponses = responses.Where(a => a.QuestionId.Equals(questionId));
            var random = thisQuestionResponses.OrderBy(g => Guid.NewGuid());
            return random;
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
                    TestName = "Emergency Medicine",
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
                    TestName = "Biostatistics",
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
                    TestName = "Cardiovascular",
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
