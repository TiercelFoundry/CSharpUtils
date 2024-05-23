namespace TiercelFoundry.CSharpUtils;

public static class StringExtensions
{
    // C# 7 Example from https://stackoverflow.com/questions/4135317/make-first-letter-of-a-string-upper-case-with-maximum-performance
    //
    public static string FirstCharToUpper(this string input)
    {
        switch (input)
        {
            case null:
                throw new ArgumentNullException(nameof(input));
            case "":
                throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
            default:
                return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }

    // Example from https://stackoverflow.com/questions/2776673/how-do-i-truncate-a-net-string
    public static string Truncate(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value)) return value;
        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }
}
