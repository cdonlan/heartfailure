using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartFailureReaddminssion.Models
{
    public class Record
    {
        public int ID { get; set; }

        public int PatientID { get; set; }
       
        public int MedicationId { get; set; }

        public DateTime ReviewDate { get; set; }

        public string ReviewUser { set; get; }

        public bool MedListComplete { get; set; }

        public virtual Patient Patient { get; set; }

    }

}