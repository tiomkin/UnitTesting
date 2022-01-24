﻿using System;
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

		[Fact]
		public void Add_NotUniqueValue_ShouldNotBeInserted()
		{
			var list = new RecentList();

			list.Add("one");
			list.Add("one");

			Assert.Contains("one", list);
			Assert.Single(list);
		}

		[Fact]
		public void LookUpByIndex_WrongIndex_Exception()
		{
			var list = new RecentList() { "one", "two", "three" };

			Action act = () => list.LookUpByIndex(-1);

			Assert.Throws<IndexOutOfRangeException>(act);
		}
	}
}
