using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatMap.BLL.Interface;
using HeatMap.Entity;

namespace HeatMap.BLL.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private HeatMapEntities _entity = null;

        public LocationRepository()
        {
            _entity = new HeatMapEntities();
        }

        public List<location> getLocations()
        {
            List<location> list = new List<location>();
            list = _entity.locations.ToList();
            return list;
        }
    }
}
