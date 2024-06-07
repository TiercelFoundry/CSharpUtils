using System.Text.Json.Serialization;

namespace TiercelFoundry.CSharpUtils;

public static class BitCompassExtensions
{
    public static BitCompass Clockwise(this BitCompass current, int steps = 1)
    {
        if (steps < 0)
        {
            return current.Anticlockwise(-steps);
        }
        byte val = (byte)current;
        steps %= 8;
        var rotated = (byte)((val << steps) | (val >> (8 - steps)));
        return (BitCompass)(unchecked(rotated)); // mask because byte and c#: https://stackoverflow.com/questions/737781/left-bit-shifting-255-as-a-byte
    }

    public static BitCompass Anticlockwise(this BitCompass current, int steps = 1)
    {
        if (steps < 0)
        {
            return current.Clockwise(-steps);
        }
        byte val = (byte)current;
        steps %= 8;
        var rotated = (byte)((val >> steps) | (val << (8 - steps)));
        return (BitCompass)(unchecked(rotated)); // mask because byte and c#: https://stackoverflow.com/questions/737781/left-bit-shifting-255-as-a-byte
    }

    public static BitCompass Opposite(this BitCompass current)
    {
        byte val = (byte)current;
        return (BitCompass)(val > 8 ? val >> 4 : val << 4);
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

    public static BitCompass FromDegrees(this float theta)
    {
        theta = theta > 360f ? theta % 360f :
            theta < 0 ? 360f - (theta % 360f) :
            theta;

        return theta switch
        {
            float when theta >= 337.5f || theta < 22.5f => BitCompass.N,
            float when theta >= 22.5f && theta < 67.5f => BitCompass.NE,
            float when theta >= 67.5f && theta < 112.5f => BitCompass.E,
            float when theta >= 112.5f && theta < 157.5f => BitCompass.SE,
            float when theta >= 157.5f && theta < 202.5f => BitCompass.S,
            float when theta >= 202.5f && theta < 247.5f => BitCompass.SW,
            float when theta >= 247.5f && theta < 292.5f => BitCompass.W,
            float when theta >= 292.5f && theta < 337.5f => BitCompass.NW,
            _ => throw new ArgumentException("Somehow theta is not clamped")
        };
    }

    public static Compass ToCompass(this BitCompass bitCompass)
    {
        int v = (int)bitCompass;
        v--;
        v |= v >> 1;
        v |= v >> 2;
        v |= v >> 4;
        v |= v >> 8;
        v |= v >> 16;
        v++;

        return (Compass)Math.Log2(v);
    }
}