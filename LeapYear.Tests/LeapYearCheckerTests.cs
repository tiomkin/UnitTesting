using Xunit;

namespace LeapYear
{
	public class LeapYearCheckerTests
	{
		[Theory]
		[InlineData(1975)]
		[InlineData(1981)]
		[InlineData(1989)]
		[InlineData(2009)]
		[InlineData(2017)]
		public void Check_YearNotDivideBy4_ReturnFalse(int year)
		{
			var checker = new LeapYearChecker();

			var result = checker.Check(year);

			Assert.False(result);
		}

		[Theory]
		[InlineData(1700)]
		[InlineData(1800)]
		[InlineData(1900)]
		[InlineData(2100)]
		[InlineData(2200)]
		public void Check_YearDivideBy4AndDivideBy100NotDivideBy400_ReturnFalse(int year)
		{
			var checker = new LeapYearChecker();

			var result = checker.Check(year);

			Assert.False(result);
		}

		[Theory]
		[InlineData(1600)]
		[InlineData(2000)]
		[InlineData(2400)]
		public void Check_YearDivideBy4AndDivideBy100AndDivideBy400_ReturnTrue(int year)
		{
			var checker = new LeapYearChecker();

			var result = checker.Check(year);

			Assert.True(result);
		}

		[Theory]
		[InlineData(1976)]
		[InlineData(1980)]
		[InlineData(1988)]
		[InlineData(2008)]
		[InlineData(2016)]
		public void Check_YearDivideBy4NotDivideBy100AndIsLeap_ReturnTrue(int year)
		{
			var checker = new LeapYearChecker();

			var result = checker.Check(year);

			Assert.True(result);
		}
	}
}
