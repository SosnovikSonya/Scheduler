using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.Races
{
    
    public abstract class SingleRace: Race
    {
        public string RaceNumber { get; set; }

        public override void Add(Race race)
        {
            
        }

        public override void Remove(Race race)
        {

        }
    }
}
