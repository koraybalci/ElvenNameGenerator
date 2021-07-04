using System;
using System.Collections.Generic;
using System.Linq;

namespace ElvenNameGenerator
{
	internal static class CollectionRandomPickerExtension
	{
		public static T PickRandomItem<T>(this ICollection<T> items, Random rnd) =>
            items.ElementAt(rnd.Next(items.Count));
    }
}
