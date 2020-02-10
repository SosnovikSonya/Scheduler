using Scheduler.Business.Entities.Races;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Scheduler.Business.Entities.DataLoad
{
    public class XMLData : IData<XmlDocument>
    {
        public XMLData(XMLLoadSettings settings)
        {
            LoadSettings = settings;
        }

        public ILoadable<XmlDocument> LoadSettings { get; }

        public List<Race> GetRaces()
        {
            var ser = new XmlSerializer(typeof(Schedule));

            using (StringReader sr = new StringReader(LoadSettings.Content.OuterXml))
            {
                var schedule = (Schedule)ser.Deserialize(sr);
            }
            // XML parse logic 
            return null;
        }         
    }
}
