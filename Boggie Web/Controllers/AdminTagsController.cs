using Microsoft.AspNetCore.Mvc;

namespace Boggie_Web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }
    }
}
