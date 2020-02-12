using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad.Json
{
    public class JsonDataLoader : DataLoader<string>
    {
        public override IData<string> LoadData(string content)
        {
            var settings = new JsonLoadSettings(content);
            return new JsonData(settings);
        }
    }
}


