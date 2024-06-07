using NUnit.Framework;

namespace TiercelFoundry.CSharpUtils.Tests;

public class CompassTests 
{
    [Test]
    public void CompassClockwiseTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Compass.N.Clockwise(), Is.EqualTo(Compass.NE));
            Assert.That(Compass.NE.Clockwise(), Is.EqualTo(Compass.E));
            Assert.That(Compass.E.Clockwise(), Is.EqualTo(Compass.SE));
            Assert.That(Compass.SE.Clockwise(), Is.EqualTo(Compass.S));
            Assert.That(Compass.S.Clockwise(), Is.EqualTo(Compass.SW));
            Assert.That(Compass.SW.Clockwise(), Is.EqualTo(Compass.W));
            Assert.That(Compass.W.Clockwise(), Is.EqualTo(Compass.NW));
            Assert.That(Compass.NW.Clockwise(), Is.EqualTo(Compass.N));

            Assert.That(Compass.N.Clockwise(4), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Clockwise(4), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Clockwise(4), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Clockwise(4), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Clockwise(4), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Clockwise(4), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Clockwise(4), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Clockwise(4), Is.EqualTo(Compass.SE));

            Assert.That(Compass.N.Clockwise(-4), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Clockwise(-4), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Clockwise(-4), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Clockwise(-4), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Clockwise(-4), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Clockwise(-4), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Clockwise(-4), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Clockwise(-4), Is.EqualTo(Compass.SE));

            Assert.That(Compass.N.Clockwise(20), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Clockwise(20), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Clockwise(20), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Clockwise(20), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Clockwise(20), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Clockwise(20), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Clockwise(20), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Clockwise(20), Is.EqualTo(Compass.SE));

            Assert.That(Compass.N.Clockwise(-20), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Clockwise(-20), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Clockwise(-20), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Clockwise(-20), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Clockwise(-20), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Clockwise(-20), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Clockwise(-20), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Clockwise(-20), Is.EqualTo(Compass.SE));
        });
    }

    [Test]
    public void CompassAnticlockwiseTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Compass.N.Anticlockwise(), Is.EqualTo(Compass.NW));
            Assert.That(Compass.NE.Anticlockwise(), Is.EqualTo(Compass.N));
            Assert.That(Compass.E.Anticlockwise(), Is.EqualTo(Compass.NE));
            Assert.That(Compass.SE.Anticlockwise(), Is.EqualTo(Compass.E));
            Assert.That(Compass.S.Anticlockwise(), Is.EqualTo(Compass.SE));
            Assert.That(Compass.SW.Anticlockwise(), Is.EqualTo(Compass.S));
            Assert.That(Compass.W.Anticlockwise(), Is.EqualTo(Compass.SW));
            Assert.That(Compass.NW.Anticlockwise(), Is.EqualTo(Compass.W));

            Assert.That(Compass.N.Anticlockwise(4), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Anticlockwise(4), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Anticlockwise(4), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Anticlockwise(4), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Anticlockwise(4), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Anticlockwise(4), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Anticlockwise(4), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Anticlockwise(4), Is.EqualTo(Compass.SE));

            Assert.That(Compass.N.Anticlockwise(-20), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Anticlockwise(-20), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Anticlockwise(-20), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Anticlockwise(-20), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Anticlockwise(-20), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Anticlockwise(-20), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Anticlockwise(-20), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Anticlockwise(-20), Is.EqualTo(Compass.SE));

            Assert.That(Compass.N.Anticlockwise(20), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Anticlockwise(20), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Anticlockwise(20), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Anticlockwise(20), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Anticlockwise(20), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Anticlockwise(20), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Anticlockwise(20), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Anticlockwise(20), Is.EqualTo(Compass.SE));

            Assert.That(Compass.N.Anticlockwise(-20), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Anticlockwise(-20), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Anticlockwise(-20), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Anticlockwise(-20), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Anticlockwise(-20), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Anticlockwise(-20), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Anticlockwise(-20), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Anticlockwise(-20), Is.EqualTo(Compass.SE));
        });
    }

    [Test]
    public void CompassOppositeTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Compass.N.Opposite(), Is.EqualTo(Compass.S));
            Assert.That(Compass.NE.Opposite(), Is.EqualTo(Compass.SW));
            Assert.That(Compass.E.Opposite(), Is.EqualTo(Compass.W));
            Assert.That(Compass.SE.Opposite(), Is.EqualTo(Compass.NW));
            Assert.That(Compass.S.Opposite(), Is.EqualTo(Compass.N));
            Assert.That(Compass.SW.Opposite(), Is.EqualTo(Compass.NE));
            Assert.That(Compass.W.Opposite(), Is.EqualTo(Compass.E));
            Assert.That(Compass.NW.Opposite(), Is.EqualTo(Compass.SE));
        });
    }

    [Test]
    public void CompassCardinalToInt4()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Compass.N.CardinalToInt4(), Is.EqualTo(0));
            Assert.That(Compass.NE.CardinalToInt4(), Is.EqualTo(0));
            Assert.That(Compass.E.CardinalToInt4(), Is.EqualTo(1));
            Assert.That(Compass.SE.CardinalToInt4(), Is.EqualTo(1));
            Assert.That(Compass.S.CardinalToInt4(), Is.EqualTo(2));
            Assert.That(Compass.SW.CardinalToInt4(), Is.EqualTo(2));
            Assert.That(Compass.W.CardinalToInt4(), Is.EqualTo(3));
            Assert.That(Compass.NW.CardinalToInt4(), Is.EqualTo(3));
        });
    }

    [Test]
    public void ToBitCompassTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Compass.N.ToBitCompass(), Is.EqualTo(BitCompass.N));
            Assert.That(Compass.NE.ToBitCompass(), Is.EqualTo(BitCompass.NE));
            Assert.That(Compass.E.ToBitCompass(), Is.EqualTo(BitCompass.E));
            Assert.That(Compass.SE.ToBitCompass(), Is.EqualTo(BitCompass.SE));
            Assert.That(Compass.S.ToBitCompass(), Is.EqualTo(BitCompass.S));
            Assert.That(Compass.SW.ToBitCompass(), Is.EqualTo(BitCompass.SW));
            Assert.That(Compass.W.ToBitCompass(), Is.EqualTo(BitCompass.W));
            Assert.That(Compass.NW.ToBitCompass(), Is.EqualTo(BitCompass.NW));
        });
    }
}
