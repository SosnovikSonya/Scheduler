using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad
{
    class CSVLoadSettings : ILoadable<string>
    {
        public string Content { get; set; }
        public string Delimitter { get; set; }
        public CSVLoadSettings(string content, string delimitter)
        {
            Content = content;
            Delimitter = delimitter;
        }
    }
}
