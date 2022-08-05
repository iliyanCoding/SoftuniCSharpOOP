namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;

        [SetUp]
        public void SetUp()
        {
            this.db = new Database();
        }

        //Valid functionality of the constructor
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorShouldAddLessThan16Elements(int[] elementsToAdd)
        {
            Database testDb = new Database(elementsToAdd);

            int[] actualData = testDb.Fetch();
            int[] expectedData = elementsToAdd;

            int actualCount = testDb.Count;
            int expectedCount = expectedData.Length;

            CollectionAssert.AreEqual(expectedData, actualData, "Database constructor should initialize data field correctly!");
            Assert.AreEqual(expectedCount, actualCount, "Constructor should set initial value for count field!");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        public void ConstructorShouldNotAllowToExceedMaximumCount(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database testDb = new Database(elementsToAdd);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void CountMustReturnActualCount()
        {
            int[] initData = new int[] { 1, 2, 3 };
            Database testDb = new Database(initData);

            int actualCount = testDb.Count;
            int expectedCount = initData.Length;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CountMustReturnZeroWhenNoElements()
        {
            int actualCount = this.db.Count;
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddShouldAddLessThan16Elements(int[] elementsToAdd)
        {
            foreach (var el in elementsToAdd)
            {
                this.db.Add(el);
            }

            int[] actualData = this.db.Fetch();
            int[] expectedData = elementsToAdd;

            int actualCount = this.db.Count;
            int expectedCount = elementsToAdd.Length;

            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddShouldThrowExceptionWhenAddingMoreThan16Elements()
        {
            for (int i = 1; i <= 16; i++)
            {
                this.db.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Add(17);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 })]
        public void RemoveShouldRemoveTheLastElementSuccesfully(int[] startElements)
        {
            foreach (var el in startElements)
            {
                this.db.Add(el);
            }

            this.db.Remove();
            List<int> elList = new List<int>(startElements);
            elList.RemoveAt(elList.Count - 1);

            int[] actualData = this.db.Fetch();
            int[] expectedData = elList.ToArray();

            int actualCount = this.db.Count;
            int expectedCount = expectedData.Length;

            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);

        }

        [Test]
        public void RemoveShouldRemoveTheLastElementMoreThanOnce()
        {
            List<int> initData = new List<int>() { 1, 2, 3 };
            foreach (var el in initData)
            {
                this.db.Add(el);
            }

            for (int i = 0; i < initData.Count; i++)
            {
                this.db.Remove();
            }

            int[] actualData = this.db.Fetch();
            int[] expectedData = new int[] { };

            int actualCount = this.db.Count;
            int expectedCount = 0;

            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveShouldThrowErrorWhenThereAreNoElements()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Remove();
            });
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCopyArray(int[] initData)
        {
            foreach (var el in initData)
            {
                this.db.Add(el);
            }

            int[] actualResult = this.db.Fetch();
            int[] expectedResult = initData;

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
