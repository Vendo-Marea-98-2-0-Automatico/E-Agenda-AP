using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace E_Agenda_AP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
