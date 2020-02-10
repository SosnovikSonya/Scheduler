using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.Races
{
    public class AircraftRace : SingleRace
    {       
        public double AllowedWeight { get; set; }
    }
}
