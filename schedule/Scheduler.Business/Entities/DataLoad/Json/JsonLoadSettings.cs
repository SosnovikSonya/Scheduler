using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad.Json
{
    public class JsonLoadSettings : ILoadable<string>
    {
        public string Content { get; set; }
      
        public JsonLoadSettings(string content)
        {
            Content = content;
        }
    }
}
