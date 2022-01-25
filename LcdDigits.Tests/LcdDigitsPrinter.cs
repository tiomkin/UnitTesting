using System;
using System.Collections.Generic;
using System.Text;

namespace LcdDigits.Tests
{
	public class LcdDigitsPrinter : ILcdDigitsPrinter
	{
		private Dictionary<int, string[]> _digitsDictionary;

		public LcdDigitsPrinter()
		{
			InitializeDigitsDictionary();
		}

		public string Print(int number)
		{
			var negative = false;

			if (number < 0)
			{
				negative = true;
				number = -number;
			}

			var listOfNumbers = GetListOfNumbersArrays(number, negative);

			var sb = new StringBuilder();

			for (int i = 0; i < 3; i++)
			{
				for (int j = listOfNumbers.Count - 1; j >= 0; j--)
				{
					sb.Append(listOfNumbers[j][i]);

					if (j != 0)
					{
						sb.Append(' ');
					}
				}

				if (i != 2)
				{
					sb.AppendLine();
				}
			}

			var result = sb.ToString();

			Console.WriteLine(result);

			return result;
		}

		private void InitializeDigitsDictionary()
		{
			_digitsDictionary = new Dictionary<int, string[]>()
			{
				[0] = new string[] {
					"._.",
					"|.|",
					"|_|"
				},
				[1] = new string[]
				{
					"...",
					"..|",
					"..|",
				},
				[9] = new string[]
				{
					"._.",
					"|_|",
					"..|"
				}
			};
		}

		private List<string[]> GetListOfNumbersArrays(int number, bool negative)
		{
			var listOfNumbers = new List<string[]>();

			if (number == 0)
			{
				listOfNumbers.Add(_digitsDictionary[0]);
				return listOfNumbers;
			}

			while (number > 0)
			{
				var digit = number % 10;
				listOfNumbers.Add(_digitsDictionary[digit]);
				number /= 10;
			}

			if (negative)
			{
				var hyphenSign = new string[]
				{
					"...",
					"._.",
					"..."
				};

				listOfNumbers.Add(hyphenSign);
			}

			return listOfNumbers;
		}
	}
}
