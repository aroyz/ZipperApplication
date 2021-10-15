using Microsoft.AspNetCore.Mvc; //import Microsoft.AspNetCore.Mvc
using System.Text.Encodings.Web; //import System.Text.Encodings.Web

namespace ZipperApplication.Controllers //start of ZipperApplication.Controllers namespace
{
    public class AboutController : Controller //start of AboutController class which inherits the controller class
    {
        public IActionResult Index() //start of Index method
        {
            return View(); //calls the controller's view method and uses a view template to generate an HTML response
        } //end of Index method
    } //end of AboutController class
} //end of ZipperApplication.Controllers namespace
