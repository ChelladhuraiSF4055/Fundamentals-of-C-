using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class Doctor
    {
        private static int s_doctorID=0;
        public  int DoctorID{get;set;}
        public string Name { get; set; }
        public string Department {get;set;}
        public Doctor()
        {
            
        }
        public Doctor(string name,string department)
        {
            s_doctorID++;
            DoctorID=s_doctorID;
            Name=name;
            Department=department;
        }
    }
}