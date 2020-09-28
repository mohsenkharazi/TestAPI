using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("default")]
    public class DefaultController : Controller
    {
        //[HttpGet]
        public string Index()
        {
            string myString = "Hi";
         
            return myString;
        }
    }
}