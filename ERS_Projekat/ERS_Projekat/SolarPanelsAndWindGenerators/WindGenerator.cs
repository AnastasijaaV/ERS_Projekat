﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ERS_Projekat.SolarPanelsAndWindGenerators
{
    public class WindGenerator : IPanelsAndGenerators
    {
        public int Production { get; set; }
        public string Name { get; set; }


        public static Random random = new Random();

        public readonly System.Timers.Timer timer;

        public static readonly object filelock = new object();

        public WindGenerator(string name)
        {
            Production = random.Next(0, 101);
            Name = name;
            timer = new System.Timers.Timer(10000);
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            File.WriteAllText($"{Name}.txt", "Vreme, Proizvodnja\n");

        }

        public void TimerElapsed(object? sender, ElapsedEventArgs e)
        {

            UpdateProduction(); //Azuriranje se poziva svakih  10 sekundi

        }

        // Azuriranje proizvodnje nasumicnim izborom broja -6 do 6
        public void UpdateProduction()
        {
            lock (filelock)
            {
                Production += new Random().Next(-6, 7);
                Production = Math.Max(0, Math.Min(100, Production));
                Log();
            }

        }

        public void Log()
        {
            lock (filelock)
            {
                string log = $"{DateTime.Now}, {Production}%\n";
                File.AppendAllText($"{Name}.txt", log);
            }

        }
    }
}
