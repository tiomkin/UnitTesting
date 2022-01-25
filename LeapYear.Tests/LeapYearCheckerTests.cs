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
	}
}
