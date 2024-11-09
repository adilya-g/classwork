using System;

namespace calculations // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine(CalculateOp(2, 0, '/'));
			}
			catch(Exception ex)
			{
				Console.WriteLine($"Произошла ошибка! {ex}");
			}
        }
		static double CalculateOp(long a, long b, char operand)
		{
			switch(operand)
			{
				case '+':
					return a + b;
				case '-':
					return a - b;
				case '*':
					return a * b;
				case '/':
					/*if (b != 0)
					{
						return (double)a / b;
					}
					return 0;*/
					return (double)(a / b);
				case '^':
					return Math.Pow(a, b);
				default:
					return default(double);
					
			}
		}
    }
}
