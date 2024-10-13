using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemApp
{
    public interface ILatLongService
    {
        Task<(double Latitude, double Longitude)> GetLatLong();
    }
}
