namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        [Test]
        public void FishConstructorTests()
        {
            Fish fish = new Fish("Ivan");
            Assert.That(fish.Name, Is.EqualTo("Ivan"));
            Assert.That(fish.Available, Is.EqualTo(true));
        }

        [Test]
        public void AquariumShouldCreateANewAquarium()
        {
            Aquarium aquarium = new Aquarium("SaltwaterAquarium", 10);
            Assert.That(aquarium.Name, Is.EqualTo("SaltwaterAquarium"));
            Assert.That(aquarium.Capacity, Is.EqualTo(10));

        }

        [Test]
        public void AquariumNameShouldNotBeNull()
        {
            
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium aquarium = new Aquarium(null, 10);
            });
        }

        [Test]
        public void AquariumNameCannotBeempty()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium aquarium = new Aquarium(string.Empty, 10);
            });
        }

        [Test]
        public void AquariumCapacityShouldBeBiggerThanZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aquarium = new Aquarium("SaltwaterAquarium", -1);
            });
        }

        [Test]
        public void CountShouldReturnTheCountOfTheFish()
        {
            Aquarium aquarium = new Aquarium("SaltwaterAquarium", 10);
            Fish fishOne = new Fish("ivan");
            Fish fishTwo = new Fish("gosho");
            Fish fishThree = new Fish("pesho");
            aquarium.Add(fishOne);
            aquarium.Add(fishTwo);
            aquarium.Add(fishThree);

            Assert.That(aquarium.Count, Is.EqualTo(3));

        }

        [Test]
        public void YouShouldNotBeAbleToAddMoreFishesIfTheAquariumIsFull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Aquarium aquarium = new Aquarium("SaltwaterAquarium", 2);
                Fish fishOne = new Fish("ivan");
                Fish fishTwo = new Fish("gosho");
                Fish fishThree = new Fish("pesho");

                aquarium.Add(fishOne);
                aquarium.Add(fishTwo);
                aquarium.Add(fishThree);
            });
        }

        public void YouShouldBeAbleToRemoveFishSuccesfully()
        {
            Aquarium aquarium = new Aquarium("SaltwaterAquarium", 10);
            Fish fishOne = new Fish("ivan");
            Fish fishTwo = new Fish("gosho");
            Fish fishThree = new Fish("pesho");

            aquarium.Add(fishOne);
            aquarium.Add(fishTwo);
            aquarium.Add(fishThree);

            aquarium.RemoveFish("ivan");
        
        }
    }
}
