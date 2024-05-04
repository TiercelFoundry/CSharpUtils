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

    public static float ToDegrees(this BitCompass compass)
    {
        return compass switch
        {
            BitCompass.N => 0f,
            BitCompass.NE => 45f,
            BitCompass.E => 90f,
            BitCompass.SE => 135f,
            BitCompass.S => 180f,
            BitCompass.SW => 225f,
            BitCompass.W => 270f,
            BitCompass.NW => 315f,
            _ => throw new ArgumentException("Invalid BitCompass", paramName: nameof(compass))
        };
    }

    public static float ToRadians(this BitCompass compass)
    {
        return compass switch
        {
            BitCompass.N => 0f * Floats.Deg2Rad,
            BitCompass.NE => 45f * Floats.Deg2Rad,
            BitCompass.E => 90f * Floats.Deg2Rad,
            BitCompass.SE => 135f * Floats.Deg2Rad,
            BitCompass.S => 180f * Floats.Deg2Rad,
            BitCompass.SW => 225f * Floats.Deg2Rad,
            BitCompass.W => 270f * Floats.Deg2Rad,
            BitCompass.NW => 315f * Floats.Deg2Rad,
            _ => throw new ArgumentException("Invalid BitCompass", paramName: nameof(compass))
        };
    }

}