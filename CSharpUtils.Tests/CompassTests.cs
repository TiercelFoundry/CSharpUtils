using NUnit.Framework;

namespace TiercelFoundry.CSharpUtils.Tests;

public class CompassTests 
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CompassClockwiseTests()
    {
        for (Compass c = Compass.N; c <= Compass.NW; c++) 
        {
            
        }
        
        Assert.Pass();
    }
}