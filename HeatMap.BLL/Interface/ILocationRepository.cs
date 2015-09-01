using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatMap.Entity;

namespace HeatMap.BLL.Interface
{
    public interface ILocationRepository
    {
        List<location> getLocations();
    }
}
