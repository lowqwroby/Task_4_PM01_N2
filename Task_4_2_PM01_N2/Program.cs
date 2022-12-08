using System;

namespace Variant10
{
	class Program
	{
		static int res(string str, int index, int i = 0)
		{
			int result = 0;
			if (index < 0)
			{
				return result;
			}
			else
			{
				if (str[index] == '1')
				{
					result += Convert.ToInt32(Math.Pow(2, i));
					return result + res(str, index - 1, i + 1);
				}
				else
				{
					return result + res(str, index - 1, i + 1);
				}
			}
		}
		static void Main()
		{
			Console.Write("Введите число в двоичной форме: ");
			string str = Console.ReadLine();
			string str1 = "";
			int a = 0;
			if (str[0] == '-')
			{
				a = -1;
				for (int i = 1; i < str.Length; i++)
				{
					if (str[i] != '1' && str[i] != '0')
					{
						Console.WriteLine("Число не в двоичной форме!");
						return;
					}
				}
				for (int i = 1; i < str.Length; i++)
				{
					str1 += str[i];
				}
			}
			else
			{
				a = 1;
				for(int i = 0; i < str.Length; i++)
				{
					if (str[i] != '1' && str[i] != '0')
					{
						Console.WriteLine("Число не в двоичной форме!");
						return;
					}
				}
				for(int i = 0; i < str.Length; i++)
				{
					str1 += str[i];
				}
			}			
			Console.WriteLine("Результат: {0}", (a * res(str1, str1.Length - 1)));
		}
	}
}