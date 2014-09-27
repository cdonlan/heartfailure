using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartFailureReaddminssion.Models
{
    public class RiskStratification
    {
        public int ID { get; set; }
        public int PatientID { get; set; }

        public int EncounterID { get; set; }

        public int FlaggedByUser { get; set; }

        public int FlaggedByNM { get; set; }

        public string HFRecordDTS { get; set; }

        public string HFRiskCD { get; set; }

        public virtual Patient Patient { get; set; }
    }
}