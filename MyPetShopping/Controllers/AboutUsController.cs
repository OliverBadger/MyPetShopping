using Microsoft.AspNetCore.Mvc;

namespace MyPetShopping.Controllers
{
    [Route("about")]
    public class AboutUsController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
