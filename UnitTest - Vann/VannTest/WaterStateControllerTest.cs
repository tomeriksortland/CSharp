using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTest___Vann;
using Assert = NUnit.Framework.Assert;

namespace VannTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test01WaterAt20Degrees()
        {
            var water = new Water(50, 20);
            Assert.AreEqual(Water.WaterState.Fluid, water.State);
            Assert.AreEqual(20, water.Temperature);
            Assert.AreEqual(50, water.Amount);
        }

        [Test]
        public void Test02WaterAtMinus20Degrees()
        {
            var water = new Water(50, -20);
            Assert.AreEqual(Water.WaterState.Ice, water.State);
            Assert.AreEqual(-20, water.Temperature);
        }

        [Test]
        public void Test03WaterAt120Degrees()
        {
            var water = new Water(50, 120);
            Assert.AreEqual(Water.WaterState.Gas, water.State);
            Assert.AreEqual(120, water.Temperature);
        }

        [Test]
        public void testforEXP()
        {
            Assert.Throws<ArgumentException>(Test04WaterAt100DegreesWithoutProportion);
        }

        public void Test04WaterAt100DegreesWithoutProportion()
        {
            var water = new Water(50, 100);
        }

        [Test]
        public void Test05WaterAt100Degrees()
        {
            var water = new Water(50, 100, 0.3);
            Assert.AreEqual(Water.WaterState.FluidAndGas, water.State);
            Assert.AreEqual(100, water.Temperature);
            Assert.AreEqual(0.3, water.ProportionFirstState);
        }

        [Test]
        public void Test08AddEnergy1()
        {
            var water = new Water(4, 10);
            water.AddEnergy(10);
            Assert.AreEqual(12.5, water.Temperature);
        }

        [Test]
        public void Test09AddEnergy2()
        {
            var water = new Water(4, -10);
            water.AddEnergy(10);
            Assert.AreEqual(-7.5, water.Temperature);
        }

        [Test]
        public void Test10AddEnergy3()
        {
            var water = new Water(4, -10);
            water.AddEnergy(168);
            Assert.AreEqual(0, water.Temperature);
            Assert.AreEqual(Water.WaterState.IceAndFluid, water.State);
            Assert.AreEqual(0.6, water.ProportionFirstState);
        }

        [Test]
        public void Test11AddEnergy4()
        {
            var water = new Water(4, -10);
            water.AddEnergy(360);
            Assert.AreEqual(0, water.Temperature);
            Assert.AreEqual(Water.WaterState.Fluid, water.State);
        }

        [Test]
        public void Test12AddEnergy5()
        {
            var water = new Water(4, -10);
            water.AddEnergy(400);
            Assert.AreEqual(10, water.Temperature);
            Assert.AreEqual(Water.WaterState.Fluid, water.State);
        }

        [Test]
        [ExpectedException(typeof(ApplicationException),
            "Cannot do state change when temperature is not 0 or 100.")]
        public void Test13InvalidStateChange()
        {
            //var water = new Water(10, 70);
            //water.AddEnergy(900);
            //Assert.AreEqual(100, water.Temperature);
            //Assert.AreEqual(Water.WaterState.FluidAndGas, water.State);
            //Assert.AreEqual(0.9, water.ProportionFirstState);
            Assert.AreEqual(1,0);
        }

        [Test]
        public void Test14FluidToGasB()
        {
            var water = new Water(10, 70);
            water.AddEnergy(900);
            Assert.AreEqual(100, water.Temperature);
            Assert.AreEqual(Water.WaterState.FluidAndGas, water.State);
            Assert.AreEqual(0.9, water.ProportionFirstState);

        }


    }
}
