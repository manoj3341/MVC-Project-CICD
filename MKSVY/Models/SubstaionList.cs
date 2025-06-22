using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MKSVY.Models
{
    public class SubstaionList
    {
        public int DIST_CODE { get; set; }
        public string DIST_NAME { get; set; }
        public int TALUKA_CODE { get; set; }
        public string TALUKA_NAME { get; set; }
        public string SUBDIVISION { get; set; }
        public string SUBSTATION_NAME { get; set; }
        public string SUBSTATION_NO { get; set; }
        public decimal SOLAR_CAPACITY_MW { get; set; }
        public decimal LAND_REQUIRED_IN_ACRE { get; set; }
        public int GOVT_FEASIBLE_LANDS { get; set; }
        public decimal GOVT_FEASIBLE_LANDS_ACRE { get; set; }
        public int PVT_FEASIBLE_LANDS { get; set; }
        public decimal PVT_FEASIBLE_LANDS_ACRE { get; set; }
        public int PROPOSAL_SUBMITED_LANDS { get; set; }
        public decimal PROPOSAL_SUBMITED_ARCE { get; set; }
        public int POSSION_RCVD_LAND { get; set; }
        public decimal POSSION_RCVD_AREA { get; set; }
        public decimal USEFUL_LAND { get; set; }
        
    }
}