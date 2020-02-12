using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Scheduler.Business.Entities.Races;
using Newtonsoft.Json;

namespace Scheduler.Business.Entities.DataLoad.Json
{
    public class JsonData : IData<string>
    {
        public JsonData(JsonLoadSettings settings)
        {
            LoadSettings = settings;
        }
        
        public ILoadable<string> LoadSettings { get; set; }

        public List<Race> GetRaces()
        {
            JsonSchedule jsonSchedule = JsonConvert.DeserializeObject<JsonSchedule>(LoadSettings.Content);
            return ConvertToListOfRaces(jsonSchedule);
        }

        private List<Race> ConvertToListOfRaces(JsonSchedule jsonSchedule)
        {
            var listRaces = new List<Race>();
            listRaces.AddRange(jsonSchedule.AircraftRaces.ConvertAll(aircraftRace => (Race)aircraftRace));
            listRaces.AddRange(jsonSchedule.BusRaces.ConvertAll(busRace => (Race)busRace));
            listRaces.AddRange(jsonSchedule.TrainRaces.ConvertAll(trainRace => (Race)trainRace));
            return listRaces;
        }
    }
}
