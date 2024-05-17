using ERS_Projekat.DistributionCentar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_Projekat.Consumer
{
    public interface IConsumer
    {
        void UI(DistributiveCenter dist);
    }
}
