using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Scheduler.Business.Entities.DataLoad.Xml
{
    public class XmlDataLoader : DataLoader<XmlDocument>
    {
        public override IData<XmlDocument> LoadData(XmlDocument content)
        {
            var settings = new XmlLoadSettings(content);
            return new XmlData(settings);
        }
    }
}
