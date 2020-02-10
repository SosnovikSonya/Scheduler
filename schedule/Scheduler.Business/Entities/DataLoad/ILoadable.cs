using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Business.Entities.DataLoad
{
    public interface ILoadable<T>
    {
        T Content { get; set; }
    }
}
