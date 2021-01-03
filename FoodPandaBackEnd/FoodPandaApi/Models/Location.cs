using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPandaApi.Models
{
    public class Location
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Road { get; set; }
        public string Building { get; set; }
        public string OtherInfo { get; set; }
    }
}
