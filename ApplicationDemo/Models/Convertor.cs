using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Models
{
	public class Convertor
	{
		[Required(ErrorMessage = "Height is Required field")]
		[Range(0.01, double.MaxValue)]
		public double? HeightInCm { get; set; }

		public double? HeightInMeter { get; set; }


		public static double? CalculateHeightInMeters(double? height)
		{
			if (height == null) return null;

			return height / 100;
		}
	}
}
