using Microsoft.AspNetCore.Mvc;

namespace ExamensArbete.Areas.HR.Controllers
{
    [Area("HR")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
