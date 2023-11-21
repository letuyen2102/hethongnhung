using DoAnMonHTN.DataAccess;
using DoAnMonHTN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAnMonHTN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger , ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Device()
        {
            return View();
        }

        public IActionResult UserLog(string deviceID, string tagID , string timestamp)
        {
            //Logs logs = new Logs()
            //{
            //    Uid = Convert,

            //};
            //_context.Logs
            return View();
        }
        public IActionResult Login()
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