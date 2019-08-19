using System;
using System.Web.Mvc;
using System.Collections.Generic;

using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            // create a new Product oblect
            Product myProduct = new Product();

            // set the property value
            myProduct.Name = "Kayak";

            // get the property 
            string productName = myProduct.Name;

            // generate the view
            return View("Result",
                (object)string.Format("Product name: {0}", productName));
        }

        public ViewResult CreateProduct()
        {
            // create and populate a new Product oblect
            Product myProduct = new Product()
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275m,
                Category = "Watersports"
            };

            // get the property 
            string productName = myProduct.Name;

            // generate the view
            return View("Result",
                (object)string.Format("Category: {0}", myProduct.Category));
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "apple", "orange", "plum" };

            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"apple", 10 }, {"orange", 20 }, {"plum", 30 }
            };

            return View("Result", (object)stringArray[1]);
        }
    }
}