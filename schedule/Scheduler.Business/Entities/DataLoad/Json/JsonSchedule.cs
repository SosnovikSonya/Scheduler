using Newtonsoft.Json;
using Scheduler.Business.Entities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad.Json
{  
    public class JsonSchedule
    {   
        public List<TrainRace> TrainRaces { get; set; }
     
        public List<BusRace> BusRaces { get; set; }
      
        public List<AircraftRace> AircraftRaces { get; set; }

        //public class TrainRaces
        //{
        //    List<TrainRace> TrainsArray { get; set; }
        //}

        //public class BusRaces
        //{
        //    List<TrainRace> BusesArray { get; set; }
        //}

        //public class AircraftRaces
        //{
        //    List<TrainRace> AircraftsArray { get; set; }
        //}
    }
}
