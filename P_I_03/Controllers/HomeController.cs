using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P_I_03.Models;

namespace P_I_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
         public IActionResult Produtos()
         {
             return View();
         }
        public IActionResult Sejaassociado()
        {
            return View();
        }
         public IActionResult Faleconosco()
         {
             return View();
         }
         public IActionResult Solicitar()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Solicitar(Servico ser)
  {
    Base.OrcamentoAtual.Incluir(ser);
    return View();
  }
  public IActionResult Listagem()
  {
     Orcamento model = Base.OrcamentoAtual;
    return View(model);
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
