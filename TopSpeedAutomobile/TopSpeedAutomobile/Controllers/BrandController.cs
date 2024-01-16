using Microsoft.AspNetCore.Mvc;
using TopSpeedAutomobile.Data;

namespace TopSpeedAutomobile.Controllers
{
    public class BrandController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public IActionResult Index()
        {
            return View();
        }
    }
}
