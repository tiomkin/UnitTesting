using System.Collections;
using System.Linq;
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

		[Fact]
		public void Add_UniqueValue_ShouldBeInserted()
		{
			var list = new RecentList();
			list.Add("one");

			Assert.Contains("one", list);
			Assert.Single(list);
		}
	}
}
