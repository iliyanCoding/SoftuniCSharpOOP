namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void ConstructorShouldMakeListOfWarriors()
        {
            Arena arena = new Arena();
            var expectedResult = new List<Warrior>();
            var actualResult = arena.Warriors;

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void CountShouldReturnTheActualCountOfTheWarriors()
        {
            var arena = new Arena();
            Warrior wariorToAttack = new Warrior("Goblin", 50, 100);
            Warrior warriorToBeAttacked = new Warrior("Barbarian", 5, 99);
            arena.Enroll(wariorToAttack);
            arena.Enroll(warriorToBeAttacked);
            int warriorsCount = arena.Count;
            Assert.That(warriorsCount, Is.EqualTo(2));

        }

        [Test]
        public void YouShouldBeAbleToEnrolNewWarriors()
        {
            var arena = new Arena();
            Warrior warior = new Warrior("Goblin", 50, 100);
            arena.Enroll(warior);
        }

        [Test]
        public void YouShouldNotBeAbleToAddTwoWarriorsWithTheSameName()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var arena = new Arena();
                Warrior warior = new Warrior("Goblin", 50, 100);
                Warrior secondWarior = new Warrior("Goblin", 10, 50);
                arena.Enroll(warior);
                arena.Enroll(secondWarior);
            });
        }


        [Test]
        public void AttackShouldLetTheAttackerToAttackTheOpponent()
        {
            var arena = new Arena();
            Warrior attacker = new Warrior("Goblin", 50, 100);
            Warrior defender = new Warrior("Barbarian", 5, 99);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight("Goblin", "Barbarian");
            Assert.That(defender.HP, Is.EqualTo(49));
        }

        [Test]
        public void AttackerIsNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var arena = new Arena();
                Warrior attacker = new Warrior("Goblin", 50, 100);
                Warrior defender = new Warrior("Barbarian", 5, 99);
                arena.Enroll(attacker);
                arena.Enroll(defender);
                arena.Fight(null, "Barbarian");
            });
        }

        [Test]
        public void DefenderIsNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var arena = new Arena();
                Warrior attacker = new Warrior("Goblin", 50, 100);
                Warrior defender = new Warrior("Barbarian", 5, 99);
                arena.Enroll(attacker);
                arena.Enroll(defender);
                arena.Fight("Goblin", null);
            });
        }
    }
}
