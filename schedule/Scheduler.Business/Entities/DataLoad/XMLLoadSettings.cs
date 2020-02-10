using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Scheduler.Business.Entities.DataLoad
{
    public class XMLLoadSettings : ILoadable<XmlDocument>
    {
        public XmlDocument Content { get; set; }
        public XMLLoadSettings(XmlDocument content)
        {
            Content = content;
        }
    }
}
