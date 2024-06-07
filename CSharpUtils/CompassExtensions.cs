namespace TiercelFoundry.CSharpUtils;

public static class CompassExtensions
{
    public static Compass Clockwise(this Compass current, int steps = 1)
    {
        var res = (int)(current + steps) % 8;
        return (Compass)(res >= 0 ? res : res + 8);
    }

    public static Compass Anticlockwise(this Compass current, int steps = 1)
    {
        return current.Clockwise(-steps);
    }

    public static Compass Opposite(this Compass current)
    {
        return current < Compass.S ? current + 4 : current - 4;
    }

    public static int ClockwiseStepsTo(this Compass start, Compass end)
    {
        return end < start ? (int)(Compass.NW - start - end) : end - start;
    }

    public static int AnticlockwiseStepsTo(this Compass start, Compass end)
    {
        return 8 - start.ClockwiseStepsTo(end);
    }

    public static bool IsCardinal(this Compass compass)
    {
        return ((int)compass & 1) == 0;
    }

    public static int CardinalToInt4(this Compass compass)
    {
        return (int)compass / 2;
    }

    public static float ToDegrees(this Compass compass)
    {
        return compass switch
        {
            Compass.N => 0f,
            Compass.NE => 45f,
            Compass.E => 90f,
            Compass.SE => 135f,
            Compass.S => 180f,
            Compass.SW => 225f,
            Compass.W => 270f,
            Compass.NW => 315f,
            _ => throw new ArgumentException("Invalid Compass", paramName: nameof(compass))
        };
    }

    public static float ToRadians(this Compass compass)
    {
        return compass switch
        {
            Compass.N => 0f * Floats.Deg2Rad,
            Compass.NE => 45f * Floats.Deg2Rad,
            Compass.E => 90f * Floats.Deg2Rad,
            Compass.SE => 135f * Floats.Deg2Rad,
            Compass.S => 180f * Floats.Deg2Rad,
            Compass.SW => 225f * Floats.Deg2Rad,
            Compass.W => 270f * Floats.Deg2Rad,
            Compass.NW => 315f * Floats.Deg2Rad,
            _ => throw new ArgumentException("Invalid Compass", paramName: nameof(compass))
        };
    }

    public static Compass FromDegrees(this float theta)
    {
        theta = theta > 360f ? theta % 360f :
            theta < 0 ? 360f - (theta % 360f) :
            theta;
        return theta switch
        {
            float when theta >= 337.5f || theta < 22.5f => Compass.N,
            float when theta >= 22.5f && theta < 67.5f => Compass.NE,
            float when theta >= 67.5f && theta < 112.5f => Compass.E,
            float when theta >= 112.5f && theta < 157.5f => Compass.SE,
            float when theta >= 157.5f && theta < 202.5f => Compass.S,
            float when theta >= 202.5f && theta < 247.5f => Compass.SW,
            float when theta >= 247.5f && theta < 292.5f => Compass.W,
            float when theta >= 292.5f && theta < 337.5f => Compass.NW,
            _ => throw new ArgumentException("Somehow theta is not clamped")
        };
    }

    public static BitCompass ToBitCompass(this Compass compass)
    {
        return (BitCompass)(Math.Pow(2, (int)compass));
    }
}
