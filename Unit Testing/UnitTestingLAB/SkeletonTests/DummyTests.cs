using NUnit.Framework;
using System;

namespace SkeletonTests
{
    [TestFixture]
    public class DummyTests
    {
        private const int DummyHealth = 10;
        private const int DummyXp = 10;

        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.dummy = new Dummy(DummyHealth, DummyXp);
        }

        [Test]
        public void DummyLosesHealthWhenAttacked()
        {
            //Arrange - done in TestInit method.

            //Act
            this.dummy.TakeAttack(5);

            //Assert
            Assert.IsTrue(this.dummy.Health < DummyHealth, "Dummy doesn't lose health after attack");
        }

        [Test]
        public void DeadDummyThrowsExceptionWhenAttacked()
        {
            //Arrange - done in TestInit method.

            //Act
            this.dummy.TakeAttack(10);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(10));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveXp()
        {
            //Arrange - done in TestInit method.

            //Act
            while (!this.dummy.IsDead())
            {
                this.dummy.TakeAttack(10);
            }

            var experienceGot = this.dummy.GiveExperience();

            //Assert
            Assert.IsTrue(DummyXp == experienceGot);
        }

        [Test]
        public void DeadDummyCannotGiveXp()
        {
            //Arrange - done in TestInit method.

            //Act

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
