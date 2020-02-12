using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Scheduler.Business.Entities.DataLoad.Xml
{
    public class XmlLoadSettings : ILoadable<XmlDocument>
    {
        public XmlDocument Content { get; set; }
        public XmlLoadSettings(XmlDocument content)
        {
            Content = content;
        }
    }
}
