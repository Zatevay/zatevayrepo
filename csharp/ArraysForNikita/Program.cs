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

			int[] a;
			a = createSingleArrayOfIntegers(6);
			showArray(a);
			showArray(sortArrayOfIntegers(a));
			Console.WriteLine(getMedian(a));


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

		static int[] sortArrayOfIntegers(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - i-1;j++)
				{
					if (array[j] > array[j + 1])
					{
						int x = array[j];
						array[j] = array[j+1];
						array[j + 1] = x;

					}
				}
			}
			return array;
		}

		static double[] sortArrayOfDoubles(double[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - i - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						double x = array[j];
						array[j] = array[j + 1];
						array[j + 1] = x;

					}
				}
			}
			return array;
		}

		static int[,] removeArrayRow(int[,] array, int row)
		{
			int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (i != row - 1)
					{
						if (i < row - 1)
							result[i, j] = array[i, j];
						else
							result[i - 1, j] = array[i, j];
					}
				}
			}
			return result;
		}

		static double[,] removeArrayRow(double[,] array, int row)
		{
			double[,] result = new double[array.GetLength(0) - 1, array.GetLength(1)];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (i != row - 1)
					{
						if (i < row - 1)
							result[i, j] = array[i, j];
						else
							result[i - 1, j] = array[i, j];
					}
				}
			}
			return result;
		}

		static int[,] removeArrayColumn(int[,] array, int column)
		{
			int[,] result = new int[array.GetLength(0), array.GetLength(1) - 1];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (j != column - 1)
					{
						if (j < column - 1)
							result[i, j] = array[i, j];
						else
							result[i, j - 1] = array[i, j];
					}
				}
			}
			return result;
		}

		static double[,] removeArrayColumn(double[,] array, int column)
		{
			double[,] result = new double[array.GetLength(0), array.GetLength(1) - 1];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (j != column - 1)
					{
						if (j < column - 1)
							result[i, j] = array[i, j];
						else
							result[i, j - 1] = array[i, j];
					}
				}
			}
			return result;
		}

		static int[,] transposeArray(int[,] array)
		{
			int[,] result = new int[array.GetLength(1), array.GetLength(0)];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result[i, j] = array[j, i]; 
				}
			}
			return result;
		}

		static double[,] transposeArray(double[,] array)
		{
			double[,] result = new double[array.GetLength(1), array.GetLength(0)];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result[i, j] = array[j, i];
				}
			}
			return result;
		}

		static int getMaximumValue(int[] array)
		{
			int result = int.MinValue;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > result)
				{
					result = array[i];
				}
			}
			return result;
		}

		static int getMaximumValue(int[,] array)
		{
			int result = int.MinValue;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i,j] > result)
					{
						result = array[i, j];
					}
				}
			}
			return result;
		}

		static double getMaximumValue(double[] array)
		{
			double result = double.MinValue;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				if (array[i] > result)
				{
					result = array[i];
				}
			}
			return result;
		}

		static double getMaximumValue(double[,] array)
		{
			double result = double.MinValue;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] > result)
					{
						result = array[i, j];
					}
				}
			}
			return result;
		}

		static int getMinimumValue(int[] array)
		{
			int result = int.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < result)
				{
					result = array[i];
				}
			}
			return result;
		}

		static int getMinimumValue(int[,] array)
		{
			int result = int.MaxValue;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] < result)
					{
						result = array[i, j];
					}
				}
			}
			return result;
		}

		static double getMinimumValue(double[] array)
		{
			double result = double.MaxValue;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				if (array[i] < result)
				{
					result = array[i];
				}
			}
			return result;
		}

		static double getMinimumValue(double[,] array)
		{
			double result = double.MaxValue;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] < result)
					{
						result = array[i, j];
					}
				}
			}
			return result;
		}

		static int getAverageValue(int[] array)
		{
			int result = 0;
			for (int i = 0; i < array.Length; i++)
			{
				result += array[i];
			}
			result = result / array.Length;
			return result;
		}

		static int getAverageValue(int[,] array)
		{
			int result = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result += array[i,j];
				}
			}
			result = result / array.Length;
			return result;
		}

		static double getAverageValue(double[] array)
		{
			double result = 0;
			for (int i = 0; i < array.Length; i++)
			{
				result += array[i];
			}
			result = result / array.Length;
			return result;
		}

		static double getAverageValue(double[,] array)
		{
			double result = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result += array[i, j];
				}
			}
			result = result / array.Length;
			return result;
		}

		static double getMedian(int[] array)
		{
			array = sortArrayOfIntegers(array);
			if (array.Length % 2 == 0)
			{
				return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2.0;
			}
			else
				return array[array.Length / 2];
		}

		static double getMedian(int[,] array)
		{
			int[] result = sortArrayOfIntegers(convertToSingleDimensionArray(array));
			if (result.Length % 2 == 0)
			{
				return (result[result.Length / 2] + result[result.Length / 2 - 1]) / 2.0;
			}
			else
				return result[result.Length / 2];
		}

		static double getMedian(double[] array)
		{
			array = sortArrayOfDoubles(array);
			if (array.Length % 2 == 0)
			{
				return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2.0;
			}
			else
				return array[array.Length / 2];
		}

		static double getMedian(double[,] array)
		{
			double[] result = sortArrayOfDoubles(convertToSingleDimensionArray(array));
			if (result.Length % 2 == 0)
			{
				return (result[result.Length / 2] + result[result.Length / 2 - 1]) / 2.0;
			}
			else
				return result[result.Length / 2];
		}

		static int[] convertToSingleDimensionArray(int[,] array)
		{
			int[] result = new int[array.Length];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result[array.GetLength(0) * i + j] = array[i, j];
				}
			}
			return result;

		}

		static double[] convertToSingleDimensionArray(double[,] array)
		{
			double[] result = new double[array.Length];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result[array.GetLength(0) * i + j] = array[i, j];
				}
			}
			return result;
		}

		static int getRandomNum(int min, int max)
		{
			return rand.Next(min, max + 1);
		}

		static bool isGreaterThanZero(int number)
		{
			if (number > 0)
				return true;
			else
				return false;
		}
		static bool isGreaterThanZero(double number)
		{
			if (number > 0)
				return true;
			else
				return false;
		}
	}
}
