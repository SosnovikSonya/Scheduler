using Scheduler.Business.Entities.Races;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Scheduler.Business.Entities.DataLoad.Xml
{
    public class XmlData : IData<XmlDocument>
    {
        public XmlData(XmlLoadSettings settings)
        {
            LoadSettings = settings;
        }

        public ILoadable<XmlDocument> LoadSettings { get; }

        public List<Race> GetRaces()
        {
            var ser = new XmlSerializer(typeof(XmlSchedule));

            using (StringReader sr = new StringReader(LoadSettings.Content.OuterXml))
            {
                var schedule = (XmlSchedule)ser.Deserialize(sr);
                return ConvertToListOfRaces(schedule);
            }
        }

        private List<Race> ConvertToListOfRaces(XmlSchedule xmlSchedule)
        {
            var listRaces = new List<Race>();
            listRaces.AddRange(xmlSchedule.AircraftRaces.ConvertAll(aircraftRace => (Race)aircraftRace));
            listRaces.AddRange(xmlSchedule.BusRaces.ConvertAll(busRace => (Race)busRace));
            listRaces.AddRange(xmlSchedule.TrainRaces.ConvertAll(trainRace => (Race)trainRace));
            return listRaces;
        }
    }
}
