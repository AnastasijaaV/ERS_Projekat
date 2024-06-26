﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_Projekat.Consumer
{
    public class Device : IDevice
    {
        public string Name { get; set; }
        public double ConsumptionPerHour { get; set; }

        public bool active { get; set; }

        public Device(string name, double consumption)
        {
            this.Name = name;
            this.ConsumptionPerHour = consumption;
            this.active = false;
        }
        public bool TurnOff()
        {
            if (active == true)
            {
                active = false;
                Console.WriteLine("Iskljucili ste uredjaj {0}.\n", Name);
                return true;
            }
            else
            {
                Console.WriteLine("{0} je vec iskljucen/a.\n", Name);
                return false;
            }
        }

        public bool TurnOn()
        {
            if (active == false)
            {
                active = true;
                Console.WriteLine("Ukljucili ste uredjaj {0}.\n", Name);
                return true;
            }
            else
            {
                Console.WriteLine("{0} je vec ukljucen/a.\n", Name);
                return false;
            }
        }
    }
}
