using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MKSVY.Models
{
    [DataContract]
    public class DataPoint
    {
        public DataPoint(string label, double y,string color,string legendText)
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
        public int Completed { get; set; }
        public int InProgress { get; set; }
        public int Yet_To_Start { get; set; }
        public int DIST_CODE { get; set; }
        public string DIST_NAME { get; set; }
        public string StatusYN { get; set; }

        [NotMapped]
        public DistrictswiseSummary DistrictsList { get; set; }
        
    }
    
}