namespace TiercelFoundry.StdUtils;


public static class IListExtensions
{
    public static T NextOrFirst<T>(this IList<T> list, T current)
    {
        int idx = list.IndexOf(current);
        if (idx == -1) 
        {
            throw new ArgumentException($"{list} does not contain {current} as an element");
        }
        else if (idx == list.Count - 1)
        {
            return list[0];
        }
        else
        {
            return list[idx + 1];
        }
    }

    public static int NextOrFirstIndex<T>(this IList<T> list, int current)
    {
        return list.Count - 1 == current ? 0 : current + 1;
    }
}
