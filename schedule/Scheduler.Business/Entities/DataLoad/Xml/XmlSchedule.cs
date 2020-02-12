using Scheduler.Business.Entities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Scheduler.Business.Entities.DataLoad.Xml
{
    [XmlRoot("schedule")]
    public class XmlSchedule
    {
        [XmlArray("trainRaces")]
        [XmlArrayItem("trainRace")]
        public List<TrainRace> TrainRaces { get; set; }
        [XmlArray("busRaces")]
        [XmlArrayItem("busRace")]
        public List<BusRace> BusRaces { get; set; }
        [XmlArray("aircraftRaces")]
        [XmlArrayItem("aircraftRace")]
        public List<AircraftRace> AircraftRaces { get; set; }
    }
}
