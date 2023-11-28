using Microsoft.AspNetCore.Mvc;

namespace ExamensArbete.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Index2(int id=0)
        {
            switch(id)
            {
                    case 1:
                    return PartialView("index2");
                    case 2:
                    return PartialView("_Index3");
                    default: return View();
            }
        }

        public IActionResult Index3()
        {
            return PartialView();
            
        }

        public IActionResult SimplePage()
        {
            return View();
        }

    }
}
