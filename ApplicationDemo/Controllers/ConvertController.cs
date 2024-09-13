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
                convertor.HeightInFoot = Convertor.CalcHeightInFoot(convertor.HeightInCm);
                convertor.HeightInInches = Convertor.CalcHeightInInches(convertor.HeightInCm);
            }
            return View(convertor);
        }

        [HttpGet]
        public IActionResult TemperatureConvertor()
        {
            return View(new Temperature());
        }

        [HttpPost]
        public IActionResult TemperatureConvertor(Temperature temperature)
        {
            if (ModelState.IsValid)
            {
                temperature.TempInCelcius = Temperature.FarenheitToCelcius(temperature.TempInFarenheit);
            }

            return View(temperature);
        }
    }
}
