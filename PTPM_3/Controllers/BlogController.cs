using Microsoft.AspNetCore.Mvc;

namespace PTPM_3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
