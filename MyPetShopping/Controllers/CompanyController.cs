using Microsoft.AspNetCore.Mvc;

namespace MyPetShopping.Controllers
{
    [Route("company")]
    public class CompanyController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
