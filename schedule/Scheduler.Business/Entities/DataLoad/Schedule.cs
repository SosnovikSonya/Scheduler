using Scheduler.Business.Entities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Scheduler.Business.Entities.DataLoad
{
    [XmlRoot("schedule")]
    public class Schedule
    {
        [XmlArray("trainRaces")]
        [XmlArrayItem("trainRace")]
        public List<TrainRace> Trains { get; set; }
        [XmlArray("busRaces")]
        [XmlArrayItem("busRace")]
        public List<BusRace> Buses { get; set; }
        [XmlArray("aircraftRaces")]
        [XmlArrayItem("aircraftRace")]
        public List<AircraftRace> Aircrafts { get; set; }
    }
}
