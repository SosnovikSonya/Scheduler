using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.Races
{
    [Serializable()]
    public class TrainRace : SingleRace
    {
        public TrainType trainType { get; set; }
    }   
}
