using Xunit;

namespace LeapYear
{
	public class LeapYearCheckerTests
	{
		[Fact(Skip = "Interface not implemented")]
		public void Check_YearNotDivideBy4_ReturnFalse()
		{
			var year = 2001;
			ILeapYearChecker checker = null;

			var result = checker.Check(year);

			Assert.False(result);
		}

		[Fact(Skip = "Interface not implemented")]
		public void Check_YearDivideBy4AndDivideBy100NotDivideBy400_ReturnFalse()
		{
			var year = 1900;
			ILeapYearChecker checker = null;

			var result = checker.Check(year);

			Assert.False(result);
		}

		[Fact(Skip = "Interface not implemented")]
		public void Check_YearDivideBy4AndDivideBy100AndDivideBy400_ReturnTrue()
		{
			var year = 2000;
			ILeapYearChecker checker = null;

			var result = checker.Check(year);

			Assert.True(result);
		}
	}
}
