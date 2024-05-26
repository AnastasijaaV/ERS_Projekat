using ERS_Projekat;
using ERS_Projekat.Consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class DeviceTest
    {
        public ERS_Projekat.Consumer.Device? dev;


        [Test]
        public void IsTurnedOn()
        {
            dev = new Device("Televizor", 4);

            dev.TurnOn();

            Assert.That(dev.active, Is.True);
        }

        [Test]
        public void IsTurnedOff()
        {
            dev = new Device("Grejalica", 1);
            dev.TurnOff();

            Assert.That(dev.active, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            dev = null;
        }
    }
}

