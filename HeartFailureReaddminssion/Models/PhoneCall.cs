using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartFailureReaddminssion.Models
{
    public class PhoneCall
    {
        public int ID { get; set; }
        public int PatientId { get; set; }

        public int CallsMade { get; set; }

        public DateTime LastCallDate { get; set; }

        public string FirstCallUser { get; set; }

        public bool PatientReached { get; set; }

        public string PatientResponse { get; set; }

        public virtual Patient Patient { get; set; }
    }
}