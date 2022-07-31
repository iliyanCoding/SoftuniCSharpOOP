using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(0), "Dummy loses health if attacked.");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);
            axe.Attack(dummy);

            Assert.That(dummy.Health)
        }
    }
}