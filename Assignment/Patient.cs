using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public enum Gender{Select,male,female}
    public class Patient
    {
        public static int s_patientID=0;
        public int PatientID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender{get;set;}
        public Patient()
        {

        }
        public Patient(string name,string password,int age, Gender gender)
        {
            s_patientID++;
            PatientID=s_patientID;
            Password=password;
            Name=name;
            Age=age;
            Gender=gender;
        }
        
    }
}