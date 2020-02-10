using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.Races
{
    public class Route : Race
    {
        public List<Race> Races { get; private set; } = new List<Race>();
        public override void Add(Race race)
        {
            Races.Add(race);
        }

        public override void Remove(Race race)
        {
            Races.Remove(race);
        }
    }
}
