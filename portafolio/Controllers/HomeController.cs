using System.Collections;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;

namespace portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

  public IActionResult AboutMe() 
  {
    ViewBag.nombre = "Daniel" ;
    ViewBag.apellido = "Lino";
    ViewBag.ocupacion = "Programador";
    ViewBag.habilidades_tecnicas = new ArrayList { "HTML","CSS","JS ECMASCRIPT6","C SHARP","JAVA","PYTHON","ASP.NET"};



    return View();
  }

    public IActionResult Index()
    {
        return View();
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
