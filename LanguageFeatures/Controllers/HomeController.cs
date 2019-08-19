using System.Web.Mvc;
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

    }
}