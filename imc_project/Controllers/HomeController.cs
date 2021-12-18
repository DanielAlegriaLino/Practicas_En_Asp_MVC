using System.Diagnostics;
using imc_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace imc_project.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	[HttpGet]
	public ViewResult Imc() 
	{
		return View("Imc_Get");
	}

	[HttpPost]
	public ViewResult Imc(string edad, string peso, string estatura) 
	{

		return View("Imc_Post");
	}



	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
