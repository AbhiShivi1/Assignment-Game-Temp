using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentGame.Models;

namespace AssignmentGame.Controllers
{
    public class GameController : Controller
    { [Authorize]
        public ActionResult checkNumber(Game obj)
        {
            if (ModelState.IsValid)
            {
                String guess = obj.Number.ToString();
                int Cow = 0;
                int Bull = 0;
                var date = DateTime.Now;
                String SecretNumber = date.ToString("ddHH");

                for (int i = 0; i < 4; i++)
                {
                    char c = SecretNumber[i];
                    for (int j = 0; j < 4; j++)
                    {
                        char d = guess[j];

                        if (c == d && i == j)
                        {
                            Bull += 1;
                        }
                        if (c == d && i != j)
                        {
                            Cow += 1;
                        }


                    }

                    if (Bull == 4)
                    {
                        ViewBag.Won = "YOU WON";
                        return View("checkNumber");
                    }
                }
                ViewBag.Cow = Cow.ToString();
                ViewBag.Bull = Bull.ToString();

                return View("CowAndBull");
            }
            else
            {
                return View("CowAndBull");
            }
        }

        public ActionResult CowAndBull()
        {

            return View();
        }
    }
    
}