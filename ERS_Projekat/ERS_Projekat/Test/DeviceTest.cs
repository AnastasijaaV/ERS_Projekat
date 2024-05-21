using ERS_Projekat.Consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ERS_Projekat.Test
{
    [TestFixture]
    public class DeviceTest
    {
        public Consumer.Device dev;
        //public Consumer.Device? dev;


        [Test]
        public void IsTurnedOn()
        {
            dev = new Device("Televizor", 4);
            //dev = new Device("Televizor", 4) ?? throw new Exception("Device initialization failed.");

            dev.TurnOn();

            ClassicAssert.AreEqual(dev.active, true);
        }

        public void IsTurnedOff()
        {
            dev = new Device("Grejalica", 1);
            dev.TurnOff();

            ClassicAssert.AreEqual(dev.active, false);
        }

        [TearDown]
        public void TearDown()
        {
            dev = null;
        }
    }
}
