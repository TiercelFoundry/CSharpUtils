using NUnit.Framework;

namespace TiercelFoundry.CSharpUtils.Tests;

public class BitCompassTests
{
    [Test]
    public void BitCompassClockwiseTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(BitCompass.N.Clockwise(), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.NE.Clockwise(), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.E.Clockwise(), Is.EqualTo(BitCompass.SE));
            Assert.That(BitCompass.SE.Clockwise(), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.S.Clockwise(), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.SW.Clockwise(), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.W.Clockwise(), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.NW.Clockwise(), Is.EqualTo(BitCompass.N));

            Assert.That(BitCompass.N.Clockwise(4), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Clockwise(4), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Clockwise(4), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Clockwise(4), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Clockwise(4), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Clockwise(4), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Clockwise(4), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Clockwise(4), Is.EqualTo(BitCompass.SE));

            Assert.That(BitCompass.N.Clockwise(-4), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Clockwise(-4), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Clockwise(-4), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Clockwise(-4), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Clockwise(-4), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Clockwise(-4), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Clockwise(-4), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Clockwise(-4), Is.EqualTo(BitCompass.SE));

            Assert.That(BitCompass.N.Clockwise(20), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Clockwise(20), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Clockwise(20), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Clockwise(20), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Clockwise(20), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Clockwise(20), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Clockwise(20), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Clockwise(20), Is.EqualTo(BitCompass.SE));

            Assert.That(BitCompass.N.Clockwise(-20), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Clockwise(-20), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Clockwise(-20), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Clockwise(-20), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Clockwise(-20), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Clockwise(-20), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Clockwise(-20), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Clockwise(-20), Is.EqualTo(BitCompass.SE));
        });
    }

    [Test]
    public void BitCompassAnticlockwiseTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(BitCompass.N.Anticlockwise(), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.NE.Anticlockwise(), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.E.Anticlockwise(), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.SE.Anticlockwise(), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.S.Anticlockwise(), Is.EqualTo(BitCompass.SE));
            Assert.That(BitCompass.SW.Anticlockwise(), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.W.Anticlockwise(), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.NW.Anticlockwise(), Is.EqualTo(BitCompass.W));

            Assert.That(BitCompass.N.Anticlockwise(4), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Anticlockwise(4), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Anticlockwise(4), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Anticlockwise(4), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Anticlockwise(4), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Anticlockwise(4), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Anticlockwise(4), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Anticlockwise(4), Is.EqualTo(BitCompass.SE));

            Assert.That(BitCompass.N.Anticlockwise(-20), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Anticlockwise(-20), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Anticlockwise(-20), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Anticlockwise(-20), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Anticlockwise(-20), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Anticlockwise(-20), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Anticlockwise(-20), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Anticlockwise(-20), Is.EqualTo(BitCompass.SE));

            Assert.That(BitCompass.N.Anticlockwise(20), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Anticlockwise(20), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Anticlockwise(20), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Anticlockwise(20), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Anticlockwise(20), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Anticlockwise(20), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Anticlockwise(20), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Anticlockwise(20), Is.EqualTo(BitCompass.SE));

            Assert.That(BitCompass.N.Anticlockwise(-20), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Anticlockwise(-20), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Anticlockwise(-20), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Anticlockwise(-20), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Anticlockwise(-20), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Anticlockwise(-20), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Anticlockwise(-20), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Anticlockwise(-20), Is.EqualTo(BitCompass.SE));
        });
    }

    [Test]
    public void ToCompassTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(BitCompass.N.ToCompass(), Is.EqualTo(Compass.N));
            Assert.That(BitCompass.NE.ToCompass(), Is.EqualTo(Compass.NE));
            Assert.That(BitCompass.E.ToCompass(), Is.EqualTo(Compass.E));
            Assert.That(BitCompass.SE.ToCompass(), Is.EqualTo(Compass.SE));
            Assert.That(BitCompass.S.ToCompass(), Is.EqualTo(Compass.S));
            Assert.That(BitCompass.SW.ToCompass(), Is.EqualTo(Compass.SW));
            Assert.That(BitCompass.W.ToCompass(), Is.EqualTo(Compass.W));
            Assert.That(BitCompass.NW.ToCompass(), Is.EqualTo(Compass.NW));
        });
    }

}