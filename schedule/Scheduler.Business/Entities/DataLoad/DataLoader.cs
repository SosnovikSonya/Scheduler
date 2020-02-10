using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad
{
    public abstract class DataLoader<T>
    {
        public abstract IData<T> LoadData(T Content);
    }
}
