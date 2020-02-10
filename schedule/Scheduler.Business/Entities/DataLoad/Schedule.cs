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

        [XmlArray("trains")]
        [XmlArrayItem("train")]
        public List<TrainRace> Trains {get; set;}
        [XmlArray("buses")]
        [XmlArrayItem("bus")]
        public List<BusRace> Buses { get; set; }
        [XmlArray("aircrafts")]
        [XmlArrayItem("aircraft")]
        public List<AircraftRace> Aircrafts { get; set; }
    }
}
