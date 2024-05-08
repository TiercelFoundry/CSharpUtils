namespace TiercelFoundry.CSharpUtils;

public static class IEnumerableExtensions
{
    // From StackOverflow: https://stackoverflow.com/questions/2471588/how-to-get-index-using-linq

    ///<summary>Finds the index of the first item matching an expression in an enumerable.</summary>
    ///<param name="items">The enumerable to search.</param>
    ///<param name="predicate">The expression to test the items against.</param>
    ///<returns>The index of the first matching item, or -1 if no items match.</returns>
    public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
    {
        if (items == null) throw new ArgumentNullException("items");
        if (predicate == null) throw new ArgumentNullException("predicate");

        int retVal = 0;
        foreach (var item in items)
        {
            if (predicate(item)) return retVal;
            retVal++;
        }
        return -1;
    }
    ///<summary>Finds the index of the first occurrence of an item in an enumerable.</summary>
    ///<param name="items">The enumerable to search.</param>
    ///<param name="item">The item to find.</param>
    ///<returns>The index of the first matching item, or -1 if the item was not found.</returns>
    public static int IndexOf<T>(this IEnumerable<T> items, T item)
    {
        return items.FindIndex(i => EqualityComparer<T>.Default.Equals(item, i));
    }

    // Random methods from https://stackoverflow.com/questions/7258824/c-elegant-code-for-getting-a-random-value-from-an-ienumerable
    public static T RandomElement<T>(this IEnumerable<T> enumerable)
    {
        return enumerable.RandomElementUsing<T>(new Random());
    }

    public static T RandomElementUsing<T>(this IEnumerable<T> enumerable, Random rand)
    {
        int index = rand.Next(0, enumerable.Count());
        return enumerable.ElementAt(index);
    }
}