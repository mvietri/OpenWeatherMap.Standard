﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Standard.Models
{

    public class AirPollution
    {
        public Coord coord { get; set; }
        public List[] list { get; set; }
    }

    public class Coord
    {
        public float lon { get; set; }
        public float lat { get; set; }
    }

    public class List
    {
        [JsonProperty("Main")]
        public AirQuality main { get; set; }
        public Components components { get; set; }
        public int dt { get; set; }
    }

    public class AirQuality
    {
        [JsonProperty("aqi")]
        public int AirQualityIndex { get; set; }
    }

    public class Components
    {
        public float co { get; set; }
        public float no { get; set; }
        public float no2 { get; set; }
        public float o3 { get; set; }
        public float so2 { get; set; }
        public float pm2_5 { get; set; }
        public float pm10 { get; set; }
        public float nh3 { get; set; }
    }

}
