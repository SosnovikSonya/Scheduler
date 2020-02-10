﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.Races
{
    abstract public class Race
    {
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public TimeSpan TravelDuration => (ArrivalTime - DepartureTime);
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public string DepartureTerminal { get; set; }
        public string ArrivalTerminal { get; set; }
        public decimal Price { get; set; }
        public abstract void Add(Race race);
        public abstract void Remove(Race race);
    }
}
