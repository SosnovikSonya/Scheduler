using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad
{
    public class CSVLDataLoader : DataLoader<string>
    {
        public override IData<string> LoadData(string content)
        {
            var settings = new CSVLoadSettings(content, ",");
            return new CSVData(settings);
        }

    }
}


