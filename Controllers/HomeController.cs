using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppTransacciones.Data;
using AppTransacciones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppTransacciones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _ctx;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        [HttpPost]
        public async Task<IActionResult> RegistrarTransaccion(Transaccion transaccion)
        {
            if(!ModelState.IsValid){
                ViewData["ErrorMessage"]="Error en el registro";
                return View("Index");
            }
            
            _ctx.Add(transaccion);

            await _ctx.SaveChangesAsync();

            ViewData["SuccessMessage"] = "Transaccion completada";

            return View("Index", transaccion);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
