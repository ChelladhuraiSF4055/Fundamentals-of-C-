using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public static class AppointmentManager
    {
        static Patient currentPatient=new Patient();
        static List<Doctor>Doctors=new List<Doctor>();
        static List<Patient>Patients=new List<Patient>();
        static List<Appointment>Appointments=new List<Appointment>();
        public static void DefaultData()
        {
            Doctor doctor1=new Doctor("Nancy","Anaesthesiology");
            Doctors.Add(doctor1);
            Doctor doctor2=new Doctor("Andrew","Cardiology");
            Doctors.Add(doctor2);
            Doctor doctor3=new Doctor("Janet","Diabetology");
            Doctors.Add(doctor3);
            Doctor doctor4=new Doctor("Margaret","Neonatology");
            Doctors.Add(doctor4);
            Doctor doctor5=new Doctor("Steven","Nephrology");
            Doctors.Add(doctor5);

            Patient patient1=new Patient("welcome","Robert",40,Gender.male);
            Patients.Add(patient1);
            Patient patient2=new Patient("welcome","Laura",36,Gender.female);
            Patients.Add(patient2);
            Patient patient3=new Patient("welcome","Anne",42,Gender.female);
            Patients.Add(patient3);

            Appointment appointment1=new Appointment(1,2,new(2012,3,8),"Heart Problem");
            Appointments.Add(appointment1);
            Appointment appointment2=new Appointment(1,5,new(2012,3,8),"Spinal cord Injury");
            Appointments.Add(appointment2);
            Appointment appointment3=new Appointment(2,2,new DateTime(2012,3,8),"Heart Attack");
            Appointments.Add(appointment3);
        }
        public static void MainMenu()
        {
            int choice;
            do
            {
            System.Console.WriteLine("Main Menu");
            System.Console.WriteLine("1.Login\n2.Register");
            choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Login Page\n");
                    Login();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Register Page\n");
                    Register();
                    break;
                }
            }
            } while(choice==1||choice==2);
        }
    static void Login()
    {
        System.Console.Write("Enter Your Name: ");
        string name=Console.ReadLine();
        System.Console.Write("Enter Your Password: ");
        string password=Console.ReadLine();
        bool exist=false;
        foreach(Patient patient in Patients)
        {
            if(patient.Name==name)
            {
                exist=true;
                if(patient.Password==password)
                {
                    currentPatient=patient;
                    SubMenu();
                }
                else
                {
                    System.Console.WriteLine("Invalid Password- Sorry Your record is Invalid\n Please register Your Profile and log in again");
                }
            }
        }
        if(!exist)
        {
            System.Console.WriteLine("Invalid  -Name Not Exist");
        }
    }
    static void SubMenu()
    {
        int option;
        do
        {
            System.Console.WriteLine("Patient Menu");
            Console.WriteLine($"1.Book Appointment\n2.View Appointment Details\n3.Edit my profile\n4.Exit");
            option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: 
                {
                    System.Console.WriteLine("Book Appointment");
                    BookAppointment();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("View Appointment Details");
                    ViewAppointmentDetails();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Edit My Profile");
                    EditMyProfile();
                    break;
                }
            }
        }while(option!=4);
    }
    static void BookAppointment()
    {
        string answer=string.Empty;
        do
        {
            string dept;
        Console.WriteLine("1.Anaesthesiology\n2.Cardiology\n3.Diabetology\n4.Neonatology\n5.Nephrology");
        int book=Convert.ToInt32(Console.ReadLine());
        switch(book)
        {
            case 1:
            {
                dept="Anaesthesiology";
                break;
            }
            case 2:
            {
                dept="Cardiology";
                break;
            }
            case 3:
            {
                dept="Diabetology";
                break;
            }
            case 4:
            {
                dept="Neonatology";
                break;
            }
            case 5:
            {
                dept="Nephrology";
                break;
            }
            default:
            {
            dept=string.Empty;
            break;
            }
        }
        foreach(Doctor doctor in Doctors)
        {
            if(doctor.Department==dept)
            {
                int count=0;
                System.Console.Write("Enter an Booking Date(dd/MM/yyyy): ");
                DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                foreach(Appointment appointment in Appointments)
                {
                    if(doctor.DoctorID==appointment.DoctorID)
                    {
                        if(appointment.Date==date)
                        {
                            count++;
                        }
                    }
                }
                
                if(count<2)
                {
                    System.Console.WriteLine($"Appointment is confirmed for the date {date.ToString("dd/MM/yyyy")}\nTo Book pres,'Y' to cancel pres 'N'.");
                    answer=Console.ReadLine().ToUpper();
                    if(answer=="Y")
                    {
                    Appointment newAppoint=new Appointment(currentPatient.PatientID,doctor.DoctorID,date,"Kidney Failure");
                    Appointments.Add(newAppoint);
                    System.Console.WriteLine("Successfully booked.");
                    }
                    else
                    {
                        System.Console.WriteLine("Appointment failed.");
                    }
                }
                else
                {
                    System.Console.WriteLine("Doctor will be engaged on that date.");
                }

            }
        }
        }while(answer!="N");

    }
    static void ViewAppointmentDetails()
    {
        foreach(Appointment appointment in Appointments)
        {
            if(currentPatient.PatientID==appointment.PatientID)
            {
                System.Console.WriteLine($"AppointmentID: {appointment.AppointmetID} PatientID: {appointment.PatientID} DoctorID: {appointment.DoctorID} Date:{appointment.Date.ToString("dd/MM/yyyy")} Problem:{appointment.Problem}");
            }
        }
    }
    static void EditMyProfile()
    {
        System.Console.Write("Enter Name: ");
        currentPatient.Name=Console.ReadLine();
        System.Console.Write("Password: ");
        currentPatient.Password=Console.ReadLine();
        System.Console.Write("Age: ");
        currentPatient.Age=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Specify Gender: ");
        currentPatient.Gender=Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Successfully edited.");
    } 
    static void Register()
    {
        System.Console.Write("Enter Your Name: ");
        string name=Console.ReadLine();
        System.Console.Write("Enter Password: ");
        string password=Console.ReadLine();
        System.Console.Write("Enter Your Age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Specify Your Gender(male/female): ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine().ToLower());
        Patient patient=new Patient(name,password,age,gender);
        Patients.Add(patient);
        System.Console.WriteLine($"Successfully Registered.Your Patient ID:{patient.PatientID}");
    }
    }
}