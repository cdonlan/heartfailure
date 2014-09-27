using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeartFailureReaddminssion.Models
{
    public class HeartFailureDBModel : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medication> Medications { get; set; }

        public DbSet<Record> Records { get; set; }

        public System.Data.Entity.DbSet<HeartFailureReaddminssion.Models.Diagnosis> Diagnosis { get; set; }

        public System.Data.Entity.DbSet<HeartFailureReaddminssion.Models.PhoneCall> PhoneCalls { get; set; }

        public System.Data.Entity.DbSet<HeartFailureReaddminssion.Models.Appointment> Appointments { get; set; }

        public System.Data.Entity.DbSet<HeartFailureReaddminssion.Models.WorkflowTracking.WorkflowInstanceEventsTable> WorkflowInstanceEventsTables { get; set; }
    }

}