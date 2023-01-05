using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class Appointment
    {
        private static int s_appointmentID=0;
        public int AppointmetID { get; set; }
        public int PatientID  { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }
        public Appointment(int patientID,int doctorID, DateTime date,string problem )
        {
            s_appointmentID++;
            AppointmetID=s_appointmentID;
            PatientID=patientID;
            DoctorID=doctorID;
            Date=date;
            Problem=problem;
        }
    }
}