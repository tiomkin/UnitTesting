using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RecentlyUsedList
{
	public class RecentList : IRecentList
	{
		private readonly string[] _recentlyUsedList;
		private static int _maxCapacity = 5;
		private int _index;

		public RecentList() : this(_maxCapacity)
		{ }

		public RecentList(int maxCapacity)
		{
			_maxCapacity = maxCapacity;
			_recentlyUsedList = new string[_maxCapacity];
			_index = 0;
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
			if (_index == _maxCapacity)
			{
				DropMostLeastItemAndRewriteArray(value);
			}

			if (string.IsNullOrEmpty(value))
			{
				return;
			}

			if (!_recentlyUsedList.Contains<string>(value))
			{
				_recentlyUsedList[_index] = value;
				_index++;
			}
		}

		private void DropMostLeastItemAndRewriteArray(string value)
		{
			for (int i = 0; i < _index - 1; i++)
			{
				_recentlyUsedList[i] = _recentlyUsedList[i + 1];
			}

			_index = _maxCapacity - 1;
			_recentlyUsedList[_index] = value;
		}

		public string LookUpByIndex(int index)
		{
			if (index < 0 || index >= _recentlyUsedList.Length)
			{
				throw new IndexOutOfRangeException("Index should equal or greater 0 and less than max items count");
			}

			return _recentlyUsedList[index];
		}
	}
}
