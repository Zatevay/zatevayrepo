using System;

namespace ArraysForNikita
{
	class MainClass
	{
		static Random rand = new Random();

		public static void Main(string[] args)
		{
			/*
			int[] array = new int[2];
			int[,] arrayD = new int[2, 2];
			int x = arrayD.GetLength(0);
			int y = arrayD.GetLength(1);
			arrayD[0, 0] = 0;
			arrayD[0, 1] = 1;
			arrayD[1, 0] = 2;
			arrayD[1, 1] = 3;
			array[0] = 1;
			array[1] = 2;
			int x = array.Length;
			Random rand = new Random();
			rand.Next();*/
			//showArray(createDoubleArrayOfDoubles(5, 3));

			double[,] a, b;
			a = createDoubleArrayOfDoubles(4, 5);
			b = createDoubleArrayOfDoubles(5, 4);
			showArray(a);
			showArray(b);
			showArray(multiplyArraysOfDoubles(a, b));

		}

		static double[,] createDoubleArrayOfDoubles(int x, int y)
		{
			double[,] array = new double[x, y];
			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					array[i, j] = rand.Next(-1000, 1001) / 100.0;
				}
			}
			return array;
		}

		static double[] createSingleArrayOfDoubles(int x)
		{
			double[] array = new double[x];
			for (int i = 0; i < x; i++)
			{
				array[i] = rand.Next(-1000, 1001) / 100.0;
			}
			return array;
		}

		static int[,] createDoubleArrayOfIntegers(int x, int y)
		{
			int[,] array = new int[x, y];
			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					array[i, j] = rand.Next(-10, 11);
				}
			}
			return array;
		}

		static int[] createSingleArrayOfIntegers(int x)
		{
			int[] array = new int[x];
			for (int i = 0; i < x; i++)
			{
				array[i] = rand.Next(-10, 11);
			}
			return array;
		}

		static void showArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + "\t");
			}
			Console.WriteLine();
		}

		static void showArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write(array[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}

		static void showArray(double[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + "\t");
			}
			Console.WriteLine();
		}

		static void showArray(double[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write(array[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}

		static int[] sortArrayOfIntegers(int[] array)
		{
			throw new NotImplementedException();
		}

		static double[] sortArrayOfDoubles(int[] array)
		{
			throw new NotImplementedException();
		}

		static int[] sumSingleArraysOfIntegers(int[] arrayX, int[] arrayY)
		{
			if (arrayX.Length == arrayY.Length)
			{
				for (int i = 0; i < arrayY.Length; i++)
				{
					arrayX[i] += arrayY[i];
				}
				return arrayX;
			}
			else
				throw new ArgumentException();
		}

		static int[,] sumDoubleArraysOfIntegers(int[,] arrayX, int[,] arrayY)
		{
			if (arrayX.GetLength(0) == arrayY.GetLength(0) && arrayX.GetLength(1) == arrayY.GetLength(1))
			{
				for (int i = 0; i < arrayX.GetLength(0); i++)
				{
					for (int j = 0; j < arrayX.GetLength(1); j++)
					{
						arrayX[i, j] += arrayY[i, j];
					}
				}
				return arrayX;
			}
			else
				throw new ArgumentException();
		}

		static double[] sumSingleArraysOfDoubles(double[] arrayX, double[] arrayY)
		{
			if (arrayX.Length == arrayY.Length)
			{
				for (int i = 0; i < arrayY.Length; i++)
				{
					arrayX[i] += arrayY[i];
				}
				return arrayX;
			}
			else
				throw new ArgumentException();
		}

		static double[,] sumDoubleArraysOfDoubles(double[,] arrayX, double[,] arrayY)
		{
			if (arrayX.GetLength(0) == arrayY.GetLength(0) && arrayX.GetLength(1) == arrayY.GetLength(1))
			{
				for (int i = 0; i < arrayX.GetLength(0); i++)
				{
					for (int j = 0; j < arrayX.GetLength(1); j++)
					{
						arrayX[i, j] += arrayY[i, j];
					}
				}
				return arrayX;
			}
			else
				throw new ArgumentException();
		}

		static double getArraySum(int[] array)
		{
			double sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}

		static double getArraySum(int[,] array)
		{
			double sum = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{ 
					sum += array[i,j];
				}
			}
			return sum;
		}

		static double getArraySum(double[] array)
		{
			double sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}

		static double getArraySum(double[,] array)
		{
			double sum = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					sum += array[i, j];
				}
			}
			return sum;
		}

		static int[,] multiplyArraysOfIntegers(int[,] arrayX, int[,] arrayY)
		{
			if (arrayX.GetLength(0) == arrayY.GetLength(1) && arrayX.GetLength(1) == arrayY.GetLength(0))
			{
				int[,] result = new int[arrayX.GetLength(0), arrayY.GetLength(1)];
				for (int i = 0; i < arrayX.GetLength(0); i++)
				{
					for (int j = 0; j < arrayY.GetLength(1); j++)
					{
						for (int t = 0; t < arrayX.GetLength(1); t++)
						{
							result[i, j] += arrayY[t, j] * arrayX[i, t];
						}
					}
				}
				return result;
			}
			else
				throw new ArgumentException();
		}

		static double[,] multiplyArraysOfDoubles(double[,] arrayX, double[,] arrayY)
		{
			if (arrayX.GetLength(0) == arrayY.GetLength(1) && arrayX.GetLength(1) == arrayY.GetLength(0))
			{
				double[,] result = new double[arrayX.GetLength(0), arrayY.GetLength(1)];
				for (int i = 0; i < arrayX.GetLength(0); i++)
				{
					for (int j = 0; j < arrayY.GetLength(1); j++)
					{
						for (int t = 0; t < arrayX.GetLength(1); t++)
						{
							result[i, j] += arrayY[t, j] * arrayX[i, t];
							result[i, j] = round(result[i, j]);
						}
					}
				}
				return result;
			}
			else
				throw new ArgumentException();
		}

		static double round(double item)
		{
			return Math.Round(item, 2);
		}
	}
}
