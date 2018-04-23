using Microsoft.AspNetCore.Mvc;
using clocks.Models;
using System;

namespace Theclock.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }
        [Route("/getangle")]
        public ActionResult getangle()
        {
          clock newclock = new clock();
          newclock.setMinute(Request.Form["minute"]);
          newclock.setMinute(Request.Form["hour"]);
          newclock.angle();
          return View("Index", newclock);
        }

    }
}
