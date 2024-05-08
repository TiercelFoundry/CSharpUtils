namespace TiercelFoundry.CSharpUtils;


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

    // From Smooth.Foundations: https://www.smooth-games.com/downloads/unity/smooth-foundations/smooth-foundations.unitypackage
    /// <summary>
    /// Shuffles the element order of the specified list.
    /// </summary>
    public static IList<T> Shuffle<T>(this IList<T> ts)
    {
        var count = ts.Count;
        var last = count - 1;
        var rng = new Random();

        for (var i = 0; i < last; ++i)
        {
            var r = rng.Next(i, last);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }

        return ts;
    }
}
