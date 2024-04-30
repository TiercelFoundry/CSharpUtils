namespace TiercelFoundry.CSharpUtils;

public static class CompassExtensions 
{
    public static Compass Clockwise(this Compass current, int steps = 1) 
    {
        return (Compass)((int)(current + steps) % 8);
    }

    public static Compass Clockwise(this Compass current) {
        return current == Compass.NW ? Compass.N : current++;
    }

    public static Compass Anticlockwise(this Compass current, int steps = 1) 
    {
        return (Compass)((int)(current - steps) % 8);
    }

    public static Compass Opposite(this Compass current)
    {
        return current < Compass.S ? current + 4 : current - 4;
    }
}
