using Microsoft.AspNetCore.Mvc;
using StartUpNETCoreProject.Database.Tables.TableHandlers;
using StartUpNETCoreProject.Models;
using System.Diagnostics;

namespace StartUpNETCoreProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoggingHandler loggingHandler;
        
        /*public HomeController(LoggingHandler loggingHandler)
        {
            loggingHandler = loggingHandler;
        }*/

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}