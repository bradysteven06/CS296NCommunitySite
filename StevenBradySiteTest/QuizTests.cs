using System;
using Xunit;
using StevenBradySite.Models;

namespace StevenBradySiteTest
{
    public class QuizTests
    {
        [Fact]
        public void TestAnswerWrong()
        {
            QuizModel choice = new QuizModel();
            QuizModel q = QuestionDB.getQuestion(2);

            choice.answer = "Marcola";

            
            Assert.False(QuizModel.IsAnswerTrue(choice.answer, q.cOption));
        }
        
        [Fact]
        public void TestAnswerCorrect()
        {
            QuizModel choice = new QuizModel();
            QuizModel q = QuestionDB.getQuestion(2);

            choice.answer = "Mohawk Highschool";

            
            Assert.True(QuizModel.IsAnswerTrue(choice.answer, q.cOption));
        }
    }
}
