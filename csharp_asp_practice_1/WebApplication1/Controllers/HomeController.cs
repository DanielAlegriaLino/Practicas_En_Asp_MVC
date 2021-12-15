﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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

		public IActionResult Peliculas()
		{
			List<Pelicula> model =	new List<Pelicula>();

			Pelicula pelicula1 = new Pelicula("Duro de matar", "110 minutos y 35 segundos", 1995) ;
			Pelicula pelicula2 = new Pelicula("Coco", "90 minutos", 2017);

			model.Add(pelicula1);
			model.Add(pelicula2);

			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}