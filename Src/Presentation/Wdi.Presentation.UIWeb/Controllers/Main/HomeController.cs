using Microsoft.AspNetCore.Mvc;

namespace Wdi.Presentation.UIWeb.Controllers.Main
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
