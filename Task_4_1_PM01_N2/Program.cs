using System;

namespace Variant10
{
	class Program
	{
		static double rec(double x, int n, int index = 0)
		{
			if (index == n)
			{
				 return x + n;
			}
			else
			{
				return index + (x / rec(x, n, index + 1));
			}
		}
		static void Main()
		{
			try
			{
				int n;
				double x;
				Console.Write("Введите x: "); x = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите n: "); n = Convert.ToInt32(Console.ReadLine());
				if(n <= 0)
				{
					throw new FormatException();
				}
				Console.WriteLine("Результат: {0:f3}", rec(x, n));
			}
			catch(FormatException)
			{
				Console.WriteLine("Введены неверные параметры.");
			}
			catch
			{
				Console.WriteLine("Что-то пошло не так...");
			}
		}
	}
}