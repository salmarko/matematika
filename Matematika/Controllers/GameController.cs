using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Matematika.Services;
using Matematika.Models;
using Matematika.Extensions;

namespace Matematika.Controllers
{
    public class GameController : Controller
    {
        private readonly ISessionService sessionService;
        private readonly ICalculationService calculationService;

        private static int currentIndex = -1;


        public GameController(
            ISessionService sessionService,
            ICalculationService calculationService)
        {
            this.sessionService = sessionService;
            this.calculationService = calculationService;
        }

        [Route("/game/mnozenje")]
        public IActionResult Multiply()
        {
            var numberPairs = calculationService.GenerateNumberPairs();
            numberPairs.Shuffle();

            sessionService.Numbers = numberPairs;

            return ShowNextQuestion();
        }

        public IActionResult ShowNextQuestion()
        {
            currentIndex++;
            var question = sessionService.Numbers[currentIndex];
            question.PageNumber = currentIndex + 1;
            question.CurrentScore = sessionService.Score;
            return View("Question", question);
        }

        [HttpPost]
        public IActionResult Answer(int answer)
        {
            var current = sessionService.Numbers[currentIndex];
            var correctAnswer = current.Multiply() == answer;

            if (correctAnswer)
            {
                sessionService.Score++;
                return ShowNextQuestion();
            }
                
            return View("EndOfGame");
        }
    }
}