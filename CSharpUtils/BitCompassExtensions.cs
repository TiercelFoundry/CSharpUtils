namespace TiercelFoundry.CSharpUtils;

public static class BitCompassExtensions
{
    public static BitCompass Clockwise(this BitCompass current, int steps = 1)
    {
        byte val = (byte)current;
        var rotated = (byte)((val << steps) | (val >> (8 - steps)));
        return (BitCompass)(unchecked(rotated)); // mask because byte and c#: https://stackoverflow.com/questions/737781/left-bit-shifting-255-as-a-byte
    }

    public static BitCompass Anticlockwise(this BitCompass current, int steps = 1)
    {
        byte val = (byte)current;
        var rotated = (byte)((val >> steps) | (val << (8 - steps)));
        return (BitCompass)(unchecked(rotated)); // mask because byte and c#: https://stackoverflow.com/questions/737781/left-bit-shifting-255-as-a-byte
    }

    public static BitCompass Opposite(this BitCompass current)
    {
        byte val = (byte)current;
        return (BitCompass)(val > 8 ? val >> 4 : val << 4);
    }
}