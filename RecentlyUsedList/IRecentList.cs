using System.Collections;
using System.Collections.Generic;

namespace RecentlyUsedList
{
	public interface IRecentList : IEnumerable<string>
	{
		public void Add(string value);
		public string LookUpByIndex(int index);
	}
}
