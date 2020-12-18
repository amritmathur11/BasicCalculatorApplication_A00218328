using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculateController : System.Web.Mvc.Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int num1=0,int num2=0,string operation="")
        {
            if(operation == null || operation == "")
            {
                return View();
            }
            int result = 0;
            bool errorState = false;
            switch(operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num2 != 0 ? num1 / num2 : 0;
                    errorState = num2 != 0 ? false : true;
                    break;
                default:
                    errorState = true;
                    break;
            }
            ViewData["result"] = result;
            if(errorState)
            {
                ViewData["result"] = "error!. divided by zero";
            }
            return View();
        }
        
    }
}