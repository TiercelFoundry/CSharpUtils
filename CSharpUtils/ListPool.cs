namespace TiercelFoundry.CSharpUtils;

public static class ListPool<T>
{
    private readonly static Stack<List<T>> stack = new();

    public static List<T> Get()
    {
        return stack.Count > 0 ? stack.Pop() : new List<T>();
    }

    public static void Add(List<T> list)
    {
        list.Clear();
        stack.Push(list);
    }
}