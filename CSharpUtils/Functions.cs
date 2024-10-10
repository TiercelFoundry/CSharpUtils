namespace TiercelFoundry.CSharpUtils;

public static class Functions
{
    public static T Identity<T>(T value) { return value; }

    public static T0 Default<T0>() { return default(T0); }
    public static T0 Default<T1, T0>(T1 _) { return default(T0); }
    /* Put as many overloads as you want */

    /* Some other potential methods */
    public static bool IsNull<T>(T entity) where T : class { return entity == null; }
    public static bool IsNonNull<T>(T entity) where T : class { return entity != null; }

    /* Put as many overloads for True and False as you want */
    public static bool True<T>(T _) { return true; }
    public static bool False<T>(T _) { return false; }
}