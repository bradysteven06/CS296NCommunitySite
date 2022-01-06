using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Models
{
    public class QuestionDB
    {
        // gets question answer set depending on number passed in
        public static QuizModel getQuestion(int qid)
        {
            QuizModel questionValue = new QuizModel();
            if (qid == 1)
            {
                questionValue.text = "A town in the Mowhawk Valley";
                questionValue.wOption1 = "Springfield";
                questionValue.cOption = "Marcola";
                questionValue.wOption2 = "Mapleton";
            }
            if (qid == 2)
            {
                questionValue.text = "Name of High school";
                questionValue.wOption1 = "Springfield Highschool";
                questionValue.wOption2 = "Marcola Highschool";
                questionValue.cOption = "Mohawk Highschool";
            }

            if (qid == 3)
            {
                questionValue.text = "Name of Elementary school";
                questionValue.cOption = "Marcola Elementary";
                questionValue.wOption1 = "Springfield Elementary";
                questionValue.wOption2 = "Sweet Home Elementary";
            }
            
            return questionValue;
        }
    }
}
