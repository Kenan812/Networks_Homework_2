using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.WeatherModels.ConcreteModels
{
    public class Root
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; } = new List<Weather>();
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
    }
}
