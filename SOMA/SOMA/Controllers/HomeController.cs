using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOMA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int SOMA = 0;
            int INDICE = 13;
            int k = 0;
            while (k < INDICE)
            {


                k = k + 1;
                SOMA = SOMA + k;



            }
            ViewBag.Message = SOMA;
            return View();
        }

       
    }
}