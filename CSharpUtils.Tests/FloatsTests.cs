using NUnit.Framework;

namespace TiercelFoundry.CSharpUtils.Tests;

public class FloatsTests
{
    [Test]
    public void RadianDegreeConstants()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Floats.Deg2Rad, Is.InRange(0.01745f, 0.01746f));
            Assert.That(Floats.Rad2Deg, Is.InRange(57.2957f, 57.2958f));
        });
    }
}