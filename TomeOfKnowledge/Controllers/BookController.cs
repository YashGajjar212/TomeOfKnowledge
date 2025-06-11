using Microsoft.AspNetCore.Mvc;

namespace TomeOfKnowledge.Controllers
{
    public class BookController : Controller
    {
        // add ready field that will be injected in controller

        // add a controller and inject the service interface
        public IActionResult GetAllBooks()
        {
            return View();
            // Call Service Call
        }
    }
}