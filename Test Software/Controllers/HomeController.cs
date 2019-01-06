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
            string resultsText = "Algorithmus:{0}\nZahlen zu Beginn:{1}\nDauer in Sekunden:{2}\nZahlen sortiert:{3}";

            int Min = 0;
            int Max = 200;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            int[] test2 = new int[100];

            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }
            string before = string.Join(",", test2);

            DateTime start = new DateTime();

            Quciksort.QuickSort(test2);

            DateTime end = new DateTime();

            TimeSpan span = end - start;
            double totalSeconds = span.TotalSeconds;

            ViewBag.ResultText = string.Format(resultsText, "Quicksort", before, totalSeconds, string.Join(",", test2));

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