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
            string? answer;
            do
            {

                Console.WriteLine("\n=============================================================");
                Console.WriteLine("Uredjaji:");

                // Prikaz dostupnih uređaja
                for (int i = 0; i < Devices.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Devices[i].Name} (ON/OFF)");
                }
                Console.WriteLine("Izlazak iz programa - X\n");

                // Unos korisničkog izbora
                Console.Write("Unesite redni broj uređaja za uključivanje/isključivanje ili napustite program: ");
                Console.WriteLine("\n=============================================================");
                answer = Console.ReadLine();

                if (int.TryParse(answer, out int index) && index >= 1 && index <= Devices.Count)
                {
                    if (Devices[index - 1].active == true)
                    {
                        Devices[index - 1].TurnOff();

                        Consumption -= Devices[index - 1].ConsumptionPerHour;
                        dist.PrintDistributionStats(Consumption);
                    }
                    else
                    {
                        Consumption += Devices[index - 1].ConsumptionPerHour;
                        if (dist.ReceivePowerDemand(Consumption))
                            Devices[index - 1].TurnOn();
                        else
                            Consumption -= Devices[index - 1].ConsumptionPerHour;
                    }

                }
                else if (answer == null)
                {
                        Console.WriteLine("Unos ne sme biti 'null vrednost'. Unesite redni broj.");
                        continue;
                }
                
                else if (!answer.ToLower().Equals("x"))
                {
                    Console.WriteLine("\n=============================================================");
                    Console.WriteLine("\nPogresan unos, pokusajte ponovo.");
                    continue;
                }

            } while (answer != null && !answer.ToLower().Equals("x"));
        }
    }
}
