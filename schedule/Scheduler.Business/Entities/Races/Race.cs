using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.Races
{
    abstract public class Race
    {
        DateTime DepartureTime { get; set; }
        DateTime ArrivalTime { get; set; }
        public TimeSpan TravelDuration => (ArrivalTime - DepartureTime);
        string DepartureCity { get; set; }
        string ArrivalCity { get; set; }
        string DepartureTerminal { get; set; }
        string ArrivalTerminal { get; set; }
        decimal Price { get; set; }
        public abstract void Add(Race race);
        public abstract void Remove(Race race);
    }
}
