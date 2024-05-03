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
        });
    }

    [Test]
    public void BitCompassOppositeTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(BitCompass.N.Opposite(), Is.EqualTo(BitCompass.S));
            Assert.That(BitCompass.NE.Opposite(), Is.EqualTo(BitCompass.SW));
            Assert.That(BitCompass.E.Opposite(), Is.EqualTo(BitCompass.W));
            Assert.That(BitCompass.SE.Opposite(), Is.EqualTo(BitCompass.NW));
            Assert.That(BitCompass.S.Opposite(), Is.EqualTo(BitCompass.N));
            Assert.That(BitCompass.SW.Opposite(), Is.EqualTo(BitCompass.NE));
            Assert.That(BitCompass.W.Opposite(), Is.EqualTo(BitCompass.E));
            Assert.That(BitCompass.NW.Opposite(), Is.EqualTo(BitCompass.SE));
        });
    }
}