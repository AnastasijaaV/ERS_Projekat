using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ERS_Projekat;

namespace TestProject1
{
    [TestFixture]
    class WindGeneratorTest
    {
        public ERS_Projekat.SolarPanelsAndWindGenerators.WindGenerator? windGenerator;

        [SetUp]
        public void Setup()
        {
            windGenerator = new ERS_Projekat.SolarPanelsAndWindGenerators.WindGenerator("Test");
        }

        [Test]
        [TestCase(0)]
        [TestCase(50)]
        public void InRange(int power)
        {
            Assert.That(windGenerator, Is.Not.Null, "windGenerator is null");
            windGenerator.Production = power;
            Assert.That(windGenerator.Production, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(100));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(101)]
        public void OutOfRange(int power)
        {
            Assert.That(windGenerator, Is.Not.Null, "windGenerator is null");
            windGenerator.Production = power;
            Assert.That(windGenerator.Production, Is.LessThan(0).Or.GreaterThan(100));
        }

        [TearDown]
        public void TearDown()
        {
            windGenerator = null;
        }
    }
}

