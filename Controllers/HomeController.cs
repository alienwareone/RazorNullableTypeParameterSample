using Microsoft.AspNetCore.Mvc;

namespace RazorNullableTypeParameterSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}