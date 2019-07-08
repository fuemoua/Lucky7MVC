using Lucky7MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lucky7MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Bet method)
        {
            Bet bet = new Bet();
            if (ModelState.IsValid)
            {
                if (method.InitialBet <= 0)
                {
                    ModelState.AddModelError("InitialBet", "Error, you must enter a number bigger than 0");
                }
                else
                {
                    bet = Calculator.CalcWins(method.InitialBet);
                }
            }
            return View(bet);
        }
    }
}