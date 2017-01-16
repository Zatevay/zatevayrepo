using System;

namespace ClassesForNikita
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Car a = new Car();
			a.Brand = "Mazda";
			a.Country = "Japan";
			a.IsAutomatic = true;
			a.MaxSpeed = 240;
			a.Model = "6";
			a.Year = 2011;


			Car b = new Car() { Brand = "Volvo", Country = "Sweden", IsAutomatic = false, MaxSpeed = 230, Model = "740", Year = 1986 };
			Console.WriteLine(a.ShowInfo());
			Console.WriteLine(b.ShowInfo());

			MyCar.brand = "Cadillac";
			MyCar.model = "Escalade";
			MyCar.country = "USA";
			MyCar.isAutomatic = true;
			MyCar.maxSpeed = 160;
			MyCar.year = 2014;

			Console.WriteLine(MyCar.ShowInfo());

		}
	}
}
