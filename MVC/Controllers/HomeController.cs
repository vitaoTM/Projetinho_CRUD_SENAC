using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastramento()
        {
            return View();
        }
        public IActionResult Destino()
        {
            return View();
        }
        
        public IActionResult PagPacotes(Pacotes pacoteNovo)       
        {
            ListaPacotes.Adicionar(pacoteNovo);
            List<Pacotes> novoPacote = ListaPacotes.Total();
            return View(novoPacote);
        }


        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
