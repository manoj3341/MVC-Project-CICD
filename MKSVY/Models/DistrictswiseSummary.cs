using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MKSVY.Models
{
    public class DistrictswiseSummary
    {
        public string DIST_NAME { get; set; }
        public string TotalSubStation { get; set; }
        public decimal TotalSolarCapacity { get; set; }
        public decimal TotalLandRequired { get; set; }
        public decimal TotalLandRequiredwith_5_tolerance { get; set; }        
        public int DIST_CODE { get; set; }

        //[NotMapped]
        public DistrictswiseSummary DistrictsList { get; set; }



    }
}