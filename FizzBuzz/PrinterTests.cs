using System;
using Xunit;

namespace FizzBuzz
{
	public class PrinterTests
	{
		[Theory(Skip = "Interface not implemented")]
		[InlineData(0)]
		[InlineData(101)]
		public void Print_AddOutOfRangeNumber_Exception(int number)
		{
			IPrinter printer = null;

			Action result = () => printer.Print(number);

			Assert.Throws<ArgumentOutOfRangeException>(result);
		}

		[Fact(Skip = "Interface not implemented")]
		public void Print_NotDivisibleBy3AndNotDivisibledBy5_ReturnNumber()
		{
			var number = 2;
			IPrinter printer = null;

			var result = printer.Print(number);

			Assert.Equal("2", result);
		}

		[Fact(Skip = "Interface not implemented")]
		public void Print_DivisibleBy3AndNotDivisibledBy5_ReturnNumber()
		{
			var number = 3;
			IPrinter printer = null;

			var result = printer.Print(number);

			Assert.Equal("Fizz", result);
		}

		[Fact(Skip = "Interface not implemented")]
		public void Print_NotDivisibleBy3AndDivisibledBy5_ReturnNumber()
		{
			var number = 5;
			IPrinter printer = null;

			var result = printer.Print(number);

			Assert.Equal("Buzz", result);
		}

		[Fact(Skip = "Interface not implemented")]
		public void Print_DivisibleBy3AndDivisibledBy5_ReturnNumber()
		{
			var number = 15;
			IPrinter printer = null;

			var result = printer.Print(number);

			Assert.Equal("FizzBuzz", result);
		}
	}
}
