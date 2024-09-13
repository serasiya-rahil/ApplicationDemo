﻿using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Models
{
	public class Convertor
	{
		[Required(ErrorMessage = "Height is Required field")]
		[Range(0.01, double.MaxValue)]
		public double? HeightInCm { get; set; }

		public double? HeightInMeter { get; set; }

		//Process Height here
		public static double? CalculateHeightInMeters(double? height)
		{
			if (height == null) return null;

			return height / 100;
		}
	}

	public class Temperature
	{
		[Required(ErrorMessage = "Temp in Farenheit is Required")]
		public double? TempInFarenheit { get; set; }

		public double? TempInCelcius { get; set; }

		public static double? FarenheitToCelcius(double? TempInFarenheit)
		{
			if (TempInFarenheit == null) return null;
			else
			{
				return ((TempInFarenheit - 32) * (5.0 / 9.0));

			}
		}
	}
}
