using System.Collections;
using Xunit;

namespace RecentlyUsedList
{
	public class RecentlyUsedListTests
	{
		[Fact(Skip = "Interface not implemented")]
		public void RecentList_InitiallyCreated_IsEmpty()
		{
			IRecentList list = null;

			Assert.Empty(list);
		}
	}
}
