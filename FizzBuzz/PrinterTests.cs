using System;
using Xunit;

namespace FizzBuzz
{
	public class PrinterTests
	{
		[Theory]
		[InlineData(0)]
		[InlineData(101)]
		public void Print_AddOutOfRangeNumber_Exception(int number)
		{
			var printer = new Printer();

			Action result = () => printer.Print(number);

			Assert.Throws<ArgumentOutOfRangeException>(result);
		}

		[Fact]
		public void Print_NotDivisibleBy3AndNotDivisibledBy5_ReturnNumber()
		{
			var number = 2;
			var printer = new Printer();

			var result = printer.Print(number);

			Assert.Equal("2", result);
		}

		[Fact]
		public void Print_DivisibleBy3AndNotDivisibledBy5_ReturnNumber()
		{
			var number = 3;
			var printer = new Printer();

			var result = printer.Print(number);

			Assert.Equal("Fizz", result);
		}

		[Fact]
		public void Print_NotDivisibleBy3AndDivisibledBy5_ReturnNumber()
		{
			var number = 5;
			var printer = new Printer();

			var result = printer.Print(number);

			Assert.Equal("Buzz", result);
		}

		[Fact]
		public void Print_DivisibleBy3AndDivisibledBy5_ReturnNumber()
		{
			var number = 15;
			var printer = new Printer();

			var result = printer.Print(number);

			Assert.Equal("FizzBuzz", result);
		}
	}
}
