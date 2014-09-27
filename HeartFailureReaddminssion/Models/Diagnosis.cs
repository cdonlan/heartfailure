using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartFailureReaddminssion.Models
{
    public class Diagnosis
    {
     
        public int DiagnosisID { get; set; }
        public int EncounterID { get; set; }
        public int LineNBR { get; set; }
        public int ICD9DiagnosisCD { get; set; }
        public bool DiagnosisPOA { get; set; }

        public string DiagnosisNM { get; set; }

        public string DiagnosisGroupDSC { get; set; }

        public int PatientID { get; set; }

        public virtual Patient Patient { get; set; }

    }
}