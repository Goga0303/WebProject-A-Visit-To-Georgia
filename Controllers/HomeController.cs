using Microsoft.AspNetCore.Mvc;
using A_Visit_To_Georgia.Models;
using Microsoft.EntityFrameworkCore;

namespace A_Visit_To_Georgia.Controllers
{
    public class HomeController : Controller
    {
        private readonly BokningbordDbContext _context;

        public HomeController(BokningbordDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View();

        public IActionResult Bokabord() => View();

        public IActionResult KontaktaOss() => View();

        
        public IActionResult SeVarMeny()
        {
            var items = _context.MenuItems
                .AsNoTracking()
                .OrderBy(m => m.Kategori)
                .ThenBy(m => m.Namn)
                .ToList();

            return View(items); 
        }
    }
}