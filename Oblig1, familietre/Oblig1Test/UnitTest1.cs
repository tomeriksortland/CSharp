using NUnit.Framework;
using Oblig1__familietre;

namespace Oblig1Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1) ";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestSomeFields()
        {
            var p = new Person
            {
                FirstName = "Torfin",
                LastName = "Tveten",
                DeathYear = 2020,
                
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Torfin Tveten Død: 2020 ";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}