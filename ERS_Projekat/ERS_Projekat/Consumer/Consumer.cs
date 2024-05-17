using ERS_Projekat.DistributionCentar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERS_Projekat.Consumer
{
    public class Consumer : IConsumer
    {

        public double Consumption { get; set; }
        public List<Device> Devices { get; set; } = new List<Device>();

        public Consumer()
        {
            Consumption = 0;
        }

        public void AddDevices(Device device)
        {
            Devices.Add(device);
        }
        public void UI(DistributiveCenter dist)
        {
            throw new NotImplementedException();
        }
    }
}
