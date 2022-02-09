using Example.Data;
using Example.Models;
using Example.ViewModel;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ExampleDbContext _context;


        public HomeController(ILogger<HomeController> logger, ExampleDbContext context)
        {
            _logger = logger;
            _context = context;

        }
            
        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                Masthead = _context.Mastheads.FirstOrDefault(),
                Portfolios = _context.Portfolios.ToList(),
                Abouts = _context.Abouts.ToList(),

            };
            return View(homeVM);
        }

        [HttpPost]
        public IActionResult Index(Contactme contact)
        {
            _context.Contactmes.Add(contact);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
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