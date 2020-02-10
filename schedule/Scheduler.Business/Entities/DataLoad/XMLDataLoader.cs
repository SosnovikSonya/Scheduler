using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Scheduler.Business.Entities.DataLoad
{
    public class XMLDataLoader : DataLoader<XmlDocument>
    {
        public override IData<XmlDocument> LoadData(XmlDocument content)
        {
            var settings = new XMLLoadSettings(content);
            return new XMLData(settings);
        }
    }
}
