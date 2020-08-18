using NUnit.Framework;
using Yatzy;

namespace YatzyTest
{
    public class Tests
    {
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
    }
}