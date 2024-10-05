using AppTransacciones.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppTransacciones.Controllers
{
    public class TransaccionController : Controller
    {
        private readonly ILogger<TransaccionController> _logger;
         private readonly ApplicationDbContext _ctx;
        public TransaccionController(ILogger<TransaccionController> logger, ApplicationDbContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public async Task<IActionResult> Index()
        {
            var transacciones = await _ctx.DataRemesa.ToListAsync();
            return View(transacciones);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}