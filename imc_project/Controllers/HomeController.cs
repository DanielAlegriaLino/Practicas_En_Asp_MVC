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
	public ViewResult Imc(int? dinero = 200) 
	{
		return View("Imc_Get");
	}

	[HttpPost]
	public ActionResult Imc(float peso, float estatura) 
	{
		try 
		{
			ViewBag.imc = peso / MathF.Pow(estatura,2);
		}catch(Exception ex) { return View("Imc_Get"); }

		
		return View("Imc_Post");

	}



	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
