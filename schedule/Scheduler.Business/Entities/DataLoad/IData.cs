using Scheduler.Business.Entities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad
{
    public interface IData<T>
    {
        List<Race> GetRaces();
        ILoadable<T> LoadSettings { get; }
    }
}
