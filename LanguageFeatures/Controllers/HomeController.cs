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
    }
}