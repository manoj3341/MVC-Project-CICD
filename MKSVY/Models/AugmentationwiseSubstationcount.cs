using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MKSVY.Models
{
     [DataContract]
    public class AugmentationwiseSubstationcount
    {
        public AugmentationwiseSubstationcount(string label, double y, string color, string legendText)
        {
            this.Label = label;
            this.Y = y;
            this.Color = color;
            this.LegendText = legendText;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "label")]
        public string Label = "";

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<double> Y = null;
        [DataMember(Name = "color")]
        public string Color = "";
        [DataMember(Name = "legendText")]
        public string LegendText = "";

        public int Id { get; set; }
        public decimal Completed { get; set; }
        public decimal InProgress { get; set; }
        public decimal Yet_To_Start { get; set; }
        public int DIST_CODE { get; set; }
        public string DIST_NAME { get; set; }
    }
}