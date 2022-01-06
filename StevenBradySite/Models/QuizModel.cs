using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Models
{
    public class QuizModel
    {
        public string quizQ1 { get; set; }
        public string answer { get; set; }
        public int qid { get; set; }
        public int correctScore { get; set; }
        public int wrongScore { get; set; }
        public string text { get; set; }
        public string cOption { get; set; }
        public string wOption1 { get; set; }
        public string wOption2 { get; set; }

        private static int minOption = 0;
        private static int maxOption = 3;
        
        public string getScore()
        {
            string correct = "You got " + correctScore + " correct and " + wrongScore + " wrong.";

            return correct;
        }

        public static bool isValid(int quizQ1)
        {
            if (quizQ1 >= minOption && quizQ1 <= maxOption) return true;
            return false;
        }

        public static bool IsAnswerTrue(string uChoice, string answer)
        {
            if (uChoice == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
