using System.Collections;
using NUnit.Framework;
using Yatzy;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRoll()
        {
            var dice = new Dice();
            dice.Roll();
            var number1 = dice.Number;
            dice.Roll();
            var number2 = dice.Number;
            Assert.AreNotEqual(0, dice.Number);
        }

        [Test]
        public void TestGetValues()
        {
            var diceSet = new DiceSet();
            var values = diceSet.GetValues();
            Assert.AreEqual(5, values.Length);
        }

        [Test]
        public void TestPointsAsOnePair()
        {
            var diceSet = new DiceSet(3, 3, 1, 2, 5);
            var points = diceSet.GetPointsAsOnePair();
            Assert.AreEqual(6, points);
        }

        [Test]
        public void TestPointsAsOnePair2()
        {
            var diceSet = new DiceSet(6, 3, 1, 2, 5);
            var points = diceSet.GetPointsAsOnePair();
            Assert.AreEqual(0, points);
        }

        [Test]
        public void TestGetCounts()
        {
            var diceSet = new DiceSet(3, 3, 1, 2, 5);
            var counts = diceSet.GetCounts();
            var expectedCounts = new[] {0, 1, 1, 2, 0, 1, 0};
            CollectionAssert.AreEqual(expectedCounts, counts);
        }
    }
}