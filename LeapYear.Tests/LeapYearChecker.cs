namespace LeapYear
{
	public class LeapYearChecker : ILeapYearChecker
	{
		public bool Check(int year)
		{
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}
	}
}
