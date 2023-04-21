using GitTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GitTest.Controllers
{
    public class ProviderController : Controller
    {
        ApplicationContext db;
        public ProviderController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Providers.ToListAsync());
        }
    }
}
