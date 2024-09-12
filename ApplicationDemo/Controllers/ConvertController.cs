using ApplicationDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDemo.Controllers
{
	public class ConvertController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View(new Convertor());
		}

		[HttpPost]
		public IActionResult Index(Convertor convertor)
		{
			//check Model State here
			if (ModelState.IsValid)
			{
				//call the fucntion and convert the height
				convertor.HeightInMeter = Convertor.CalculateHeightInMeters(convertor.HeightInCm);
			}
			return View(convertor);
		}
	}
}
