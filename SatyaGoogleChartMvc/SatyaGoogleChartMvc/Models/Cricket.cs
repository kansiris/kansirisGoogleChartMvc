using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SatyaGoogleChartMvc.Models
{
    public class CricketModel
    {
        public string CricketYear { get; set; }
        public string CenturyTitle { get; set; }
        public string HalfCenturyTitle { get; set; }
        public Cricket CricketData { get; set; }
    }
    public class Cricket
    {
        public string Year { get; set; }
        public string Century { get; set; }
        public string HalfCentury { get; set; }
    }
}