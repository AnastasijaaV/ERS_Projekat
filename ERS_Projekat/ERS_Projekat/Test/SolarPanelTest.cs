using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_Projekat.Test
{
    [TestFixture]
    public class SolarPanelTest
    {
        // public SolarPanelsAndWindGenerators.SolarPanel solarPanel;
        public SolarPanelsAndWindGenerators.SolarPanel? solarPanel;



        [SetUp]
        public void Setup()
        {
            solarPanel = new SolarPanelsAndWindGenerators.SolarPanel("Test");
        }

        [Test]
        [TestCase(0)]
        [TestCase(50)]
        public void InRange(int power)
        {
            //solarPanel.Production = power;
            solarPanel!.Production = power;
            Assert.That(solarPanel.Production, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(100));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(101)]
        public void OutOfRange(int power)
        {
            // solarPanel.Production = power;
            solarPanel!.Production = power;
            Assert.That(solarPanel.Production, Is.LessThan(0).Or.GreaterThan(100));
        }

        [TearDown]
        public void TearDown()
        {
            solarPanel = null;
        }




    }
}
