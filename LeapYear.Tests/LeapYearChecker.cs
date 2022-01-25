namespace LeapYear
{
	public class LeapYearChecker : ILeapYearChecker
	{
		public bool Check(int year)
		{
			if (year % 4 == 0)
			{
				if (year % 100 == 0)
				{
					if (year % 400 == 0)
					{
						return true;
					}

					return false;
				}

				return true;
			}

			return false;
		}
	}
}
