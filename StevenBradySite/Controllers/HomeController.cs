using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StevenBradySite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Controllers
{
    public class HomeController : Controller
    {
        private IMessageRepository msg { get; set; }
             

        public HomeController(IMessageRepository newMessage)
        {
            msg = newMessage;
        }
                
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.messages = msg.GetMessages();
            return View();
        }

        [HttpPost]
        public IActionResult Contact(MessageModel model)
        {
            // Add New Message and Save
            msg.AddMessage(model);

            // Display messages
            ViewBag.messages = msg.GetMessages();
            return View();
        }

        [HttpGet]
        public IActionResult NewMessage(int id)
        {
            MessageModel message;
            ViewBag.messages = msg.GetMessages();

            if (id > 0)
            {
                //Load Message
                message = msg.FindMessage(id);
                ViewBag.button = "Update";
            }
            else
            {
                message = new MessageModel();
                ViewBag.button = "Submit";
            }

            return View(message);
        }

        [HttpGet]
        public IActionResult QuizView()
        {
          
            ViewBag.qid = 1;

            //Get Question Text
            QuizModel question = QuestionDB.getQuestion(ViewBag.qid);
            ViewBag.QuestionText = question.text;
            ViewBag.AnswerCorrect = question.cOption;
            ViewBag.AnswerWrong1 = question.wOption1;
            ViewBag.AnswerWrong2 = question.wOption2;


            return View();
        }

        [HttpPost]
        public IActionResult QuizView(QuizModel quizStat)
        {
           //***Functional quiz, but does not count point for final question***

            ViewBag.correctScore = quizStat.correctScore;
            ViewBag.wrongScore = quizStat.wrongScore;
            ViewBag.qid = quizStat.qid + 1;

            // check answer and score point
            if (QuizModel.IsAnswerTrue(quizStat.answer, quizStat.cOption))
            {
                ViewBag.correctScore++;
            }
            else
            {
                ViewBag.wrongScore++;
            }



            //Get Question Text
            QuizModel question = QuestionDB.getQuestion(ViewBag.qid);
            ViewBag.QuestionText = question.text;
            ViewBag.AnswerCorrect = question.cOption;
            ViewBag.AnswerWrong1 = question.wOption1;
            ViewBag.AnswerWrong2 = question.wOption2;

            ModelState.Clear();

            // checks for quiz finished
            if (ViewBag.qid > 3)
            {
                ViewBag.result = quizStat.getScore();
                return View("QuizResultView");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
