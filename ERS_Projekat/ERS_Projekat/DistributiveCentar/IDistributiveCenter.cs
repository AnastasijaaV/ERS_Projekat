using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_Projekat.DistributionCentar
{
    public interface IDistributiveCenter
    {
        bool ReceivePowerDemand(double demand);

        void PrintDistributionStats(double consumption);
        void AdjustHydroelectricPlantProduction(double demand);
    }
}
