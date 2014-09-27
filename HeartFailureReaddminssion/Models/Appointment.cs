using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartFailureReaddminssion.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public DateTime EntryTime { get; set; }

        public string AppointmentProvider { set; get; }

        public string AppointmentDepartment { get; set; }

        public string AppointmentScheduledBy { get; set; }

        public string AppointmentCheckIn { get; set; }

        public string AppointmentStatus { get; set; }

        public string OutpatioentHospitalAccount { get; set; }

        public virtual Patient Patient { get; set; }


    }
}