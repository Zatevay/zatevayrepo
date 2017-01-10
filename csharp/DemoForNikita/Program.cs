using System;

namespace DemoForNikita
{
	class Program
	{
		public static void Main()
		{
			/*
			for (double x = -3; x <= 3; x += 0.2)
			{
				for (double y = -3; y <= 3; y += 0.2)
				{
					if ((y >= 0 && Math.Sqrt(x) >= y && x * x >= y && x * x + y * y <= 9) || (x * x + y * y <= 9 && x * x >= y && y >= -x))
						Console.WriteLine(x + " " + y);
				}
			}

			Console.WriteLine("X\tY\tA\tB\tR");
			for (int x = 0; x <= 1; x++)
			{
				for (int y = 0; y <= 1; y++)
				{
					for (int a = 0; a <= 1; a++)
					{
						for (int b = 0; b <= 1; b++)
						{
							bool r;
							if ((!toBool(x) && toBool(y)) || (!toBool(a) && toBool(b)))
								r = true;
							else
								r = false;
							Console.WriteLine(x + "\t" + y + "\t" + a + "\t" + b + "\t" + toInt(r));
						}
					}
				}
			}
		

			Console.WriteLine("Vvedi i");
			int i = int.Parse(Console.ReadLine());
			Console.WriteLine("Vvedi N");
			int N = int.Parse(Console.ReadLine());
			if (N > i && i >= 3)
			{
				Console.Clear();
				int preprev = 1;
				int prev = 1;
				int sum = 0;
				Console.WriteLine(preprev);
				Console.WriteLine(prev);
				for (int g = 3; g <= N; g++)
				{
					int temp = prev + preprev;
					preprev = prev;
					prev = temp;
					if (g >= i)
						sum += temp;
					Console.WriteLine(temp);
				}
				Console.WriteLine("sum =" + sum);
			}
			*/

			Console.WriteLine("Vvedi pervoe chislo");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Vvedi vtoroe chislo");
			int b = int.Parse(Console.ReadLine());
			bool loop = true;
			while (loop)
			{
				if (a > b)
					a = a - b;
				else
					b = b - a;
				if (a == b)
				{
					Console.WriteLine(a);
					loop = false;
				}
			}

			       
		}

		static bool toBool(int val)
		{
			if (val == 0)
				return false;
			else
				return true;
		}

		static int toInt(bool per)
		{
			if (per)
				return 1;
			else
				return 0;
		}
	}
}
