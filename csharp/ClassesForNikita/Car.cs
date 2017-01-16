using System;

namespace ClassesForNikita
{
	class Car
	{
		private string brand;
		private string model;
		private int year;
		private int maxSpeed;
		private string country;
		private bool isAutomatic;
		private string[] allowedCountries = new string[] { "Germany", "USA", "France", "Japan", "Sweden" };

		public string Brand
		{
			get
			{
				return brand;
			}

			set
			{
				brand = value;
			}
		}

		public string Model
		{
			get
			{
				return model;
			}
			set
			{
				model = value;
			}
		}

		public int Year
		{
			get
			{
				return year;
			}
			set 
			{
				if (value >= 1970 && value <= 2017)
				{
					year = value;
				}
				else
					throw new ArgumentException();
			}
		}

		public int MaxSpeed
		{
			get
			{
				return maxSpeed;
			}
			set
			{
				if (value <= 450)
					maxSpeed = value;
				else
					throw new ArgumentException();
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set
			{
				bool correct = false;
				foreach (string allowedCountry in allowedCountries)
				{
					if (allowedCountry == value)
					{
						country = value;
						correct = true;
						break;
					}
				}
				if (!correct)
					throw new ArgumentOutOfRangeException();
			}
		}

		public bool IsAutomatic
		{
			get
			{
				return isAutomatic;
			}
			set
			{
				isAutomatic = value;
			}
		}

		public string ShowInfo()
		{
			return "This is " + brand + " " + model + ". It was made in " + year + " in " + country + " . And its maximum speed " + maxSpeed + " , with " +
				(isAutomatic ? "automatic" : "manual") + " transmission.";
		}
	}
}
