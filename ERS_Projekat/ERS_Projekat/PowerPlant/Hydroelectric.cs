﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_Projekat.PowerPlant
{
    public class Hydroelectric : IHydroelectric
    {
        public int Production { get; set; }

        public Hydroelectric()
        {
            this.Production = 0;
            File.WriteAllText("hydroEl.txt", "Vreme, Proizvodnja\n");
        }

        // Procenat proizvodnje mora biti u opsegu 0-100
        public void UpdateProduction(int production)
        {
            if (production < 0 || production > 100)
            {
                throw new ArgumentOutOfRangeException("Procenat proizvodnje hidroelektrane je van opsega!");
            }
            Production = production;
        }

        public void Log()
        {
            string log = $"{DateTime.Now}, {Production}%\n";
            File.AppendAllText("hydroEl.txt", log);
        }
    }
}
