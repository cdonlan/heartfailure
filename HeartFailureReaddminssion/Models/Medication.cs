using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartFailureReaddminssion.Models
{
    public class Medication
    {
        public int Id { get; set; }

        public int EncounterId { get; set; }

        public int MedicationId { get; set; }

        public bool TakingFLG { get; set; }

        public string ShortGenericNM { get; set; }

        public string PharmaClassDSC { get; set; }

        public string MedicationDSC { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderNM { get; set; }

        public string DiscontinueDTS { get; set; }

        public virtual Patient Patient { get; set; }


 
    }
}