using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Models
{
    public class Convertor
    {
        [Required(ErrorMessage = "Height is Required field")]
        [Range(0.01, double.MaxValue)]
        public double? HeightInCm { get; set; }

        public double? HeightInMeter { get; set; }

        public double? HeightInInches { get; set; }

        public double? HeightInFoot { get; set; }

        //Process Height in meters here
        public static double? CalculateHeightInMeters(double? height)
        {
            if (height == null) return null;

            return height / 100;
        }

        //process height in inches here
        public static double? CalcHeightInInches(double? height)
        {
            if (height == null) return null;
            else
            {
                return Math.Round((double)height / 2.54);
            }
        }

        // process height in foot here
        public static double? CalcHeightInFoot(double? height)
        {
            if (height == null) return null;
            else
            {
                return Math.Round((double)(height / 30.48));
            }
        }

    }

    public class Temperature
    {
        [Required(ErrorMessage = "Temp in Farenheit is Required")]
        [DisplayName("Temperature in Fahrenheit °F")]
        public double? TempInFarenheit { get; set; }

        [DisplayName("Temperature in Celcius °C")]
        public double? TempInCelcius { get; set; }

        public static double? FarenheitToCelcius(double? TempInFarenheit)
        {
            if (TempInFarenheit == null) return null;
            else
            {
                return Math.Round((double)((TempInFarenheit - 32) * (5.0 / 9.0)), 2);
            }
        }
    }
}
