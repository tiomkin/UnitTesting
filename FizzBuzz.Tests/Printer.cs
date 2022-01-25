using System;

namespace FizzBuzz
{
	public class Printer : IPrinter
	{
		public string Print(int number)
		{
			if (number < 1 || number > 100)
			{
				throw new ArgumentOutOfRangeException(nameof(number));
			}

			if (number % 15 == 0)
			{
				Console.WriteLine("FizzBuzz");
				return "FizzBuzz";
			}

			if (number % 3 == 0)
			{
				Console.WriteLine("Fizz");
				return "Fizz";
			}

			if (number % 5 == 0)
			{
				Console.WriteLine("Buzz");
				return "Buzz";
			}

			Console.WriteLine(number);
			return number.ToString();
		}
	}
}
