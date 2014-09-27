using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HeartFailureReaddminssion.Models
{
    public class Patient
    {
        [Display(Name = "Patient ID")]
        public int ID { get; set;}

        [Display(Name = "Encounter ID")]
        public int EncounterID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Admitted Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Admitted { get; set; }

        [Display(Name = "Discharge Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Discharge { get; set; }

        [Display(Name = "Admitted Location")]
        public string AdmittedLocation { get; set; }

        public string State { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<Diagnosis> Diagnoses { get; set; }

        public virtual ICollection<Medication> Medications { get; set; }

        public virtual ICollection<Record> Records { get; set; }

        public virtual ICollection<PhoneCall> PhoneCalls { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<RiskStratification> RiskStratifications { get; set; }

    }
}