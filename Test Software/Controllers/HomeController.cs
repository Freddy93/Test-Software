using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_Software.Classes;

namespace Test_Software.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string resultsText = "Algorithmus:{0}<br>Zahlen zu Beginn:{1}<br>Dauer in Sekunden:{2}<br>Zahlen sortiert:{3}";

            int Min = 0;
            int Max = 200;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            int[] test2 = new int[11];

            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }
            string before = string.Join(",", test2);

            DateTime start = DateTime.Now;

            BogoSort.Sort(test2);

            DateTime end = DateTime.Now;

            TimeSpan span = end - start;
            double totalSeconds = span.TotalSeconds;

            ViewBag.ResultText = string.Format(resultsText, "Bogosort", before, totalSeconds, string.Join(",", test2));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}