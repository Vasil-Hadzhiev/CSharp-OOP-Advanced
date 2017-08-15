using NUnit.Framework;
using System;

namespace SkeletonTests
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 1;
        private const int AxeDurability = 1;
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arange - done in TestInit method.

            //Act
            this.axe.Attack(this.dummy);

            //Assert
            Assert.AreEqual(9, this.axe.DurabilityPoints, "Axe Durability doesn't change after atack");
        }

        [Test]
        public void BrokenAxeAttack()
        {
            //Arange - done in TestInit method.

            //Act
            this.axe.Attack(this.dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.axe.Attack(this.dummy));
            Assert.AreEqual("Axe is broken.", ex.Message);
        }
    }
}
