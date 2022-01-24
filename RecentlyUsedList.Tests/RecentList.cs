using System;
using System.Collections;
using System.Collections.Generic;

namespace RecentlyUsedList
{
	public class RecentList : IRecentList
	{
		private List<string> _recentlyUsedList;
		private readonly byte _maxCapacity = 5;

		public RecentList()
		{
			_recentlyUsedList = new List<string>(_maxCapacity);
		}

		public IEnumerator<string> GetEnumerator()
		{
			foreach (var item in _recentlyUsedList)
			{
				yield return item;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(string value)
		{
			if (!_recentlyUsedList.Contains(value))
			{
				_recentlyUsedList.Add(value);
			}
		}

		public string LookUpByIndex(int index)
		{
			throw new System.NotImplementedException();
		}
	}
}
