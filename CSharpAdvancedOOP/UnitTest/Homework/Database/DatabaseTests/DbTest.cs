namespace DatabaseTests
{
    using DatabaseExample;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class DbTest
    {
        [Test]
        public void EmptyConstructorShouldInintData()
        {
            
            Database db = new Database();

            Assembly assembly = Assembly.GetAssembly(typeof(Database));

            Type type = assembly
                .GetTypes()
                .First(t => t.Name == "Database");

            var field = type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(f => f.Name == "data")
                .GetValue(db);

            int[] fieldArray = (int[])field;

            int actualFieldLenght = fieldArray.Length;
            int expectedFieldLenght = 16;

            Assert.AreEqual(expectedFieldLenght, actualFieldLenght);
        }

        [Test]
        public void EmptyConstructorShouldInintIndexToMinusOne()
        {
            Database db = new Database();

            Assembly assembly = Assembly.GetAssembly(typeof(Database));

            Type type = assembly
                .GetTypes()
                .First(t => t.Name == "Database");

            int field = (int)type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(f => f.Name == "index")
                .GetValue(db);

            int initialArrayIndex = -1;
            int expected = -1;
            Assert.AreEqual(expected, initialArrayIndex);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 })]
        public void CtorShouldThrowInvalidOperationExceptionWithLargerArray(int[] values)
        {
            Assert.Throws<InvalidOperationException>(() => new Database(values));
        }

        [Test]
        [TestCase(new int[] { }, ExpectedResult = -1)]
        [TestCase(new int[] { 1 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, ExpectedResult = 15)]
        public int CtorShouldSetIndexCorectly(int[] values)
        {
            Database db = new Database(values);

            Assembly assembly = Assembly.GetAssembly(typeof(Database));

            Type type = assembly
                .GetTypes()
                .First(t => t.Name == "Database");

            int index = (int)type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(f => f.Name == "index")
                .GetValue(db);

            return index;
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void AddShouldIncreaseIndexCorrectly(int[] values)
        {
            Database db = new Database(values);
            Assembly assembly = Assembly.GetAssembly(typeof(Database));

            Type type = assembly
                .GetTypes()
                .First(t => t.Name == "Database");

            db.Add(1);

            int index = (int)type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(f => f.Name == "index")
                .GetValue(db);

            int expectedIndex = values.Length;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddShouldThrowInvalidOperationExceptionWhenDatabaseIsFull(int[] values)
        {
            Database db = new Database(values);

            Assert.Throws<InvalidOperationException>(() => db.Add(1));
        }

        [Test]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void RemoeShouldDecreaseIndexCorectly(int[] values)
        {
            Database db = new Database(values);
            Assembly assembly = Assembly.GetAssembly(typeof(Database));

            Type type = assembly
                .GetTypes()
                 .First(t => t.Name == "Database");

            db.Remove();

            int index = (int)type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(f => f.Name == "index")
                .GetValue(db);

            int expectedIndex = values.Length - 2;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        [TestCase(new int[] { })]
        public void RemoveShouldThworInvalidOperationExceptionWhenDBIsEmpty(int[] values)
        {
            Database db = new Database(values);

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }
    }
}
