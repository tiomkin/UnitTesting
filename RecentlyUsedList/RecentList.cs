using System;
using System.Collections;
using System.Collections.Generic;

namespace RecentlyUsedList
{
	public class RecentList : IRecentList
	{
		private readonly List<string> _recentlyUsedList;
		private static int _maxCapacity = 5;

		public RecentList() : this(_maxCapacity)
		{ }

		public RecentList(int maxCapacity)
		{
			_maxCapacity = maxCapacity;
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

			if (string.IsNullOrEmpty(value))
			{
				return;
			}

			if (_recentlyUsedList.Count == _maxCapacity)
			{
				_recentlyUsedList.RemoveAt(_maxCapacity - 1);
			}

			if (!_recentlyUsedList.Contains(value))
			{
				_recentlyUsedList.Insert(0, value);
			}
		}

		public string LookUpByIndex(int index)
		{
			if (index < 0 || index >= _recentlyUsedList.Count)
			{
				throw new IndexOutOfRangeException("Index should equal or greater 0 and less than max items count");
			}

			return _recentlyUsedList[index];
		}
	}
}
