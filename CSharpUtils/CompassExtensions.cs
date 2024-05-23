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
}
