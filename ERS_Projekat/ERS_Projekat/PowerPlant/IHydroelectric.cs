﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_Projekat.PowerPlant
{
    public interface IHydroelectric
    {
        void UpdateProduction(int production);
        void Log();
    }
}
