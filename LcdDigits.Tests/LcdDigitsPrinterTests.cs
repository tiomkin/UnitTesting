using System;
using Xunit;

namespace LcdDigits.Tests
{
	public class LcdDigitsPrinterTests
	{
		[Fact]
		public void Print_PositiveNumber_PrintWithoutHyphen()
		{
			var number = 910;
			var expected = @"
			    ._. ... ._.
				|_| ..| |.|
				..| ..| |_|";

			var printer = new LcdDigitsPrinter();

			var result = printer.Print(number);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Print_Zero_PrintWithoutHyphen()
		{
			var number = 0;
			var expected = @"
._.
|.|
|_|";

			var printer = new LcdDigitsPrinter();

			var result = printer.Print(number);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Print_NegativeNumber_PrintWithHyphen()
		{
			var number = -910;
			var expected = @"
			  ... ._. ... ._.
			  ._. |_| ..| |.|
			  ... ..| ..| |_|";

			var printer = new LcdDigitsPrinter();

			var result = printer.Print(number);

			Assert.Equal(expected, result);
		}
	}
}
