﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class AirQuality
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Components
        {
            public int co { get; set; }
            public double no { get; set; }
            public double no2 { get; set; }
            public double o3 { get; set; }
            public double so2 { get; set; }
            public double pm2_5 { get; set; }
            public double pm10 { get; set; }
            public double nh3 { get; set; }
        }

        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class List
        {
            public Main main { get; set; }
            public Components components { get; set; }
            public int dt { get; set; }
        }

        public class Main
        {
            public int aqi { get; set; }
        }

        public class Root
        {
            public Coord coord { get; set; }
            public List<List> list { get; set; }
        }


    }
}
