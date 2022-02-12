using Example.Areas.admin.ViewModel;
using Example.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Example.Areas.admin.Controllers
{
    public class PortfoliosController
    {
        [Area("admin")]
        public class PortfoliosController : Controller
        {
            private readonly ExampleDbContext _context;

            public PortfoliosController(ExampleDbContext context)
            {
                _context = context;

            }


            public IActionResult Index()
            {

                AdminVM vm = new()
                {
                    Portfolios = _context.Portfolios.ToList()
                };
                return View(vm);
            }
        }
    }
}