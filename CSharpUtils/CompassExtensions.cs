namespace TiercelFoundry.CSharpUtils;

public static class CompassExtensions 
{
    public static Compass Clockwise(this Compass current, int steps = 1) 
    {
        return (Compass)(Math.Abs((int)(current + steps) % 8));
    }

    public static Compass Clockwise(this Compass current) {
        return current == Compass.NW ? Compass.N : current++;
    }

    public static Compass Anticlockwise(this Compass current, int steps = 1) 
    {
        return (Compass)(Math.Abs((int)(current - steps) % 8));
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

    public static bool IsCardinal (this Compass compass)
    {
        return ((int)compass & 1) == 0;
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
}
