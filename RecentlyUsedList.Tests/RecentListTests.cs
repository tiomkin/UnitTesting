using System.Collections;
using Xunit;

namespace RecentlyUsedList
{
	public class RecentListTests
	{
		[Fact]
		public void RecentList_InitiallyCreated_IsEmpty()
		{
			var list = new RecentList();

			Assert.Empty(list);
		}
	}
}
