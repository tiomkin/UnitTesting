using System;
using System.Collections;
using System.Collections.Generic;

namespace RecentlyUsedList
{
	public class RecentList : IRecentList
	{
		private List<string> _recentlyUsedList;
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
			if (_recentlyUsedList.Count == _maxCapacity)
			{
				DropMostLeastItemAndRewriteList(value);
			}

			if (string.IsNullOrEmpty(value))
			{
				return;
			}

			if (!_recentlyUsedList.Contains(value))
			{
				_recentlyUsedList.Add(value);
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

		private void DropMostLeastItemAndRewriteList(string value)
		{
			for (int i = 0; i < _maxCapacity - 1; i++)
			{
				_recentlyUsedList[i] = _recentlyUsedList[i + 1];
			}

			_recentlyUsedList[^1] = value;
		}
	}
}
