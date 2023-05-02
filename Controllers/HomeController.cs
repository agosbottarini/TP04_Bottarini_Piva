using Microsoft.AspNetCore.Mvc;

namespace TP04_Bottarini_Piva.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
