using System;
using System.Collections.Generic;
using System.Linq;

namespace ElvenNameGenerator
{
	internal static class ICollectionRandomPickerExtension
	{
		public static T PickRandomItem<T>(this ICollection<T> items, Random rnd)
		{
			return items.ElementAt(rnd.Next(items.Count));
		}
	}
}
