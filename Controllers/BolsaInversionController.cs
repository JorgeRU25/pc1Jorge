using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc1Jorge.Models;

namespace pc1Jorge.Controllers
{
    public class BolsaInversionController : Controller
    {
        private readonly ILogger<BolsaInversionController> _logger;

        public BolsaInversionController(ILogger<BolsaInversionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Bolsa()
        {
            ViewData["listaBolsas"] = new List<Bolsa>();
            return View();
        }

        
        public IActionResult Create (Bolsa bolsa)
        {

            if (bolsa.Instrumentos == null)
            {
                bolsa.Instrumentos = new List<string>(); // Inicializa si está vacío
            }

            bolsa.CalcularInversion();

            // Agregar la bolsa a una lista (ejemplo)
            List<Bolsa> listaBolsas = new List<Bolsa>
            {
                bolsa
            };

            ViewData["listaBolsas"] = listaBolsas;
            return View("Bolsa");
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}