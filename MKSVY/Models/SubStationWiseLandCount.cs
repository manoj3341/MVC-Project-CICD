using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MKSVY.Models
{
    public class SubStationWiseLandCount
    {
        public int Id { get; set; }
        public string Completed { get; set; }
        public string InProgress { get; set; }
        public string Yet_To_Start { get; set; }
        public string TotalSubStation { get; set; }
        public string TOTAL_SOLAR_CAPACITY { get; set; }
        public string TOTAL_LAND { get; set; }
        public string Record_Type { get; set; }
        public int DIST_CODE { get; set; }
        public string DIST_NAME { get; set; }
    }
}