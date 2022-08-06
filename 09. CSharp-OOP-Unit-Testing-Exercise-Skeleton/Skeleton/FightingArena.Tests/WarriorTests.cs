namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void ConstructorShouldMakeANewWarrior()
        {
            Warrior warior = new Warrior("Goblin", 10, 40);
            Assert.That(warior.Name, Is.EqualTo("Goblin"));
            Assert.That(warior.Damage, Is.EqualTo(10));
            Assert.That(warior.HP, Is.EqualTo(40));
        }

        [Test]
        public void WarriorNameShouldNotBeWhitespace()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warior = new Warrior("", 10, 40);
            });
        }

        [Test]
        public void WarriorNameShouldNotBeNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warior = new Warrior(null, 10, 40);
            });
        }

        [Test]
        public void DamageShouldNotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warior = new Warrior("Goblin", -10, 40);
            });
        }

        [Test]
        public void HPShouldBePositive()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warior = new Warrior("Goblin", 10, -50);
            });
        }

        [Test]
        public void YouShouldNotAttackIfYourHPIsTooLow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Warrior wariorToAttack = new Warrior("Goblin", 10, 29);
                Warrior warriorToBeAttacked = new Warrior("Barbarian", 15, 40);
                wariorToAttack.Attack(warriorToBeAttacked);
            });
        }

        [Test]
        public void YouShouldNotAttackIfYourEnemyHPIsTooLow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Warrior wariorToAttack = new Warrior("Goblin", 10, 39);
                Warrior warriorToBeAttacked = new Warrior("Barbarian", 15, 20);
                wariorToAttack.Attack(warriorToBeAttacked);
            });
        }

        [Test]
        public void YouShouldNotAttackIfYourEnemyDamageIsHigherThanYourHp()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Warrior wariorToAttack = new Warrior("Goblin", 10, 10);
                Warrior warriorToBeAttacked = new Warrior("Barbarian", 20, 20);
                wariorToAttack.Attack(warriorToBeAttacked);
            });
        }

        [Test]
        public void Attack()
        {
            Warrior wariorToAttack = new Warrior("Goblin", 10, 100);
            Warrior warriorToBeAttacked = new Warrior("Barbarian", 5, 50);
            wariorToAttack.Attack(warriorToBeAttacked);
            Assert.That(warriorToBeAttacked.HP, Is.EqualTo(40));
        }

        [Test]
        public void WarriorDamageIsHigherThanEnemyHp()
        {
            Warrior wariorToAttack = new Warrior("Goblin", 50, 100);
            Warrior warriorToBeAttacked = new Warrior("Barbarian", 5, 49);
            wariorToAttack.Attack(warriorToBeAttacked);
            Assert.That(warriorToBeAttacked.HP, Is.EqualTo(0));
        }

        
    }
}