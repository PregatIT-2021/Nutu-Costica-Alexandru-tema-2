using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMathStrategy _mathStrategy;
    

        public HomeController(IMathStrategy mathStrategy)
        {
            _mathStrategy = mathStrategy;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/Add/{a}/{b}")]
        public IActionResult Add(int a, int b)
        {
            int result = _mathStrategy.Calculate(a, b, Operator.Add);
            return View(new ComputationViewModel { A=a, B=b, Result = result.ToString() });
        }

        [Route("/Substract/{a}/{b}")]
        public IActionResult Substract(int a, int b)
        {
            int result = _mathStrategy.Calculate(a, b, Operator.Substract);
            return View(new ComputationViewModel { A = a, B = b, Result = result.ToString() });
        }

        [Route("/Multiply/{a}/{b}")]
        public IActionResult Multiply(int a, int b)
        {
            int result = _mathStrategy.Calculate(a, b, Operator.Multiply);
            return View(new ComputationViewModel { A = a, B = b, Result = result.ToString() });
        }

        [Route("/Divide/{a}/{b}")]
        public IActionResult Divide(int a, int b)
        {
            if (b == 0) return View(new ComputationViewModel { Error = "Division by zero error!" });

            int result = _mathStrategy.Calculate(a, b, Operator.Divide);
            return View(new ComputationViewModel { A = a, B = b, Result = result.ToString() });
        }

    }
}
