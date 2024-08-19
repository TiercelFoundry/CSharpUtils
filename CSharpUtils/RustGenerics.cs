using System.Diagnostics.CodeAnalysis;

namespace TiercelFoundry.CSharpUtils.Rusty;

public static class RustGenerics
{
    public static T Expect<T>([NotNull] this T? obj, string message) where T : class
    {
        if (obj == null)
        {
            throw new NullReferenceException(message);
        }

        return obj;
    }
}