using System;
namespace ClassesForNikita
{
	static class MyCar
	{
		public static string brand;
		public static string model;
		public static int year;
		public static int maxSpeed;
		public static string country;
		public static bool isAutomatic;

		public static string ShowInfo()
		{
			return "This is " + brand + " " + model + ". It was made in " + year + " in " + country + " . And its maximum speed " + maxSpeed + " , with " +
				(isAutomatic ? "automatic" : "manual") + " transmission.";
		}
	}
}
