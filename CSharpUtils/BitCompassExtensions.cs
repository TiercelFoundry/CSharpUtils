namespace TiercelFoundry.CSharpUtils;

public static class BitCompassExtensions
{
    public static BitCompass Clockwise(this BitCompass current, int steps = 1)
    {
        byte val = (byte)current;
        return (BitCompass)(val << steps | val >> 8 - steps);
    }

    public static BitCompass Anticlockwise(this BitCompass current, int steps = 1)
    {
        byte val = (byte)current;
        return (BitCompass)(val >> steps | val << 8 - steps);
    }

    public static BitCompass Opposite(this BitCompass current)
    {
        byte val = (byte)current;
        return (BitCompass)(val << 4 | val >> 4);
    }
}