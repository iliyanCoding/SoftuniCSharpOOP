namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {

        //[Test]
        //public void FirstConstructorTest()
        //{
        //    Car car = new Car();
        //    Assert.That(car.FuelAmount, Is.EqualTo(0));
        //}

        [Test]
        public void SecondConstructorTest()
        {
            Car car = new Car("Toyota", "Supra", 10, 100);
            Assert.That(car.Make, Is.EqualTo("Toyota"));
            Assert.That(car.Model, Is.EqualTo("Supra"));
            Assert.That(car.FuelConsumption, Is.EqualTo(10));
            Assert.That(car.FuelCapacity, Is.EqualTo(100));
        }

        [Test]
        public void MakeCannotBeEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("", "Supra", 10, 100);
            });
        }

        [Test]
        public void MakeCannotBeNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(null, "Supra", 10, 100);
            });
        }

        [Test]
        public void ModelCannotBeEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "", 10, 100);
            });
        }

        [Test]
        public void ModelCannotBeNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", null, 10, 100);
            });
        }

        [Test]
        public void FuelConsumptionCannotBeZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Supra", 0, 100);
            });
        }

        [Test]
        public void FuelConsumptionCannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Supra", -5, 100);
            });
        }

        [Test]
        public void FuelCapacityCannotBeZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Supra", 10, 0);
            });
        }

        [Test]
        public void FuelCapacityCannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Supra", 10, -10);
            });
        }

        [Test]
        public void FuelAmmountShouldBeZeroWhenFirstCreatingTheCar()
        {
            Car car = new Car("Lamborghini", "Urus", 30, 300);
            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [Test]
        public void RefuelShouldAddFuelToTheCar()
        {
            Car car = new Car("Lamborghini", "Urus", 30, 300);
            car.Refuel(50);
            Assert.That(car.FuelAmount, Is.EqualTo(50));
        }

        [Test]
        public void RefuelMethodShouldNotAddZeroFuel()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Lamborghini", "Urus", 30, 300);
                car.Refuel(0);
            });
        }

        [Test]
        public void RefuelMethodShouldNotAddNegativeFuel()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Lamborghini", "Urus", 30, 300);
                car.Refuel(-5);
            });
        }

        [Test]
        public void YouShouldNotAddFuelThatExceedsTheCapacity()
        {
            Car car = new Car("Lamborghini", "Urus", 30, 80);
            car.Refuel(90);
            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }

        [Test]
        public void DriveTest()
        {
            Car car = new Car("Lamborghini", "Urus", 20, 300);
            car.Refuel(300);
            car.Drive(100);
            Assert.That(car.FuelAmount, Is.EqualTo(280));

        }

        [Test]
        public void DriveTestNumber2()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Car car = new Car("Lamborghini", "Urus", 20, 300);
                car.Refuel(10);
                car.Drive(100);
            });
        }
    }
}