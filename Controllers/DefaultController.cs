using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Route("default")]
    public class DefaultController : Controller
    {
        //[HttpGet]
        public string Index()
        {
            string myString = null;

            // testting verbatim string
            myString = @"c:\user\mohsen";

            //testing nullable data types
            int? myVar = null;
            myString = myVar.ToString();

            //data type conversion
            float myFloatVar = 123.45F;
            int myIntVar = (int)myFloatVar;

            //testing arrays --> arrays are not type safe you may point to unavailable index of arrayear
            string[] myArrVar = new string[] { "Mohsen", "Unknown"};

            myString = "";
            foreach (var item in EvenNumbers(20))
            {            
                myString += myString + item.ToString() + " ";   
            }
         
            return myString;
        }

        private static IEnumerable<int> EvenNumbers(int limit)
        {
            int start = 0;
            Collection<int> evenNumberColl = new Collection<int>();


            while (start <= limit)
            {
                evenNumberColl.Add(start);
                start += 2;
            }

            return evenNumberColl;
        }
    }
}