using NUnit.Framework;

namespace TiercelFoundry.CSharpUtils.Tests;

public class ObjectTests
{
    internal class TestObject
    {
        public int Id { get; set; }
        public string Name { get; protected set; }
        public float Value { get; private set; }
        public SubClass SubClass { get; set; }
        private SubClass SubClass2 { get; set; }
    }

    internal class SubClass
    {
        public decimal SubVal;
        private uint Register;
    }

    internal struct TestStruct
    {
        int x, y, z;
        public int A, B, C;
    }

    [Test]
    public void CopySimpleClassTest()
    {
        var instance = new SubClass
        {
            SubVal = 1.01M,
        };

        var copy = instance.Copy();
        Assert.That(copy.SubVal, Is.EqualTo(instance.SubVal));
    }

    [Test]
    public void CopySimpleStructTest()
    {
        var instance = new TestStruct
        {
            A = 1,
            B = 2,
            C = 3,
        };

        var copy = instance.Copy();
        Assert.Multiple(() =>
        {
            Assert.That(copy.A, Is.EqualTo(instance.A));
            Assert.That(copy.B, Is.EqualTo(instance.B));
            Assert.That(copy.C, Is.EqualTo(instance.C));
        });
    }

    [Test]
    public void CopyNestedClassTest()
    {
        var instance = new TestObject
        {
            Id = 5,
            SubClass = new SubClass
            {
                SubVal = 512.42M
            },
        };

        var copy = instance.Copy();
        Assert.Multiple(() =>
        {
            Assert.That(copy.Id, Is.EqualTo(instance.Id));
            Assert.That(copy.SubClass.SubVal, Is.EqualTo(instance.SubClass.SubVal));
        });
    }
}
