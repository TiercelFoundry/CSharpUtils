using TiercelFoundry.StdUtils;

namespace StdUtils.Tests;

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