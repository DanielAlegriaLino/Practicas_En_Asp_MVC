using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csharp_asp_practice_2.Models;

namespace csharp_asp_practice_2.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	[HttpGet]
	public string peliculas(string? a_texto_prueba)
	{
		return "holamundo" + a_texto_prueba;
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
