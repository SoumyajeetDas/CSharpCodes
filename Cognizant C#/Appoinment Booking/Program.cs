using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appoinment_Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidAppointmentDate;

            try
            {
                PatientDetail patientDetail = new PatientDetail();

                string doctorname = string.Empty;

                Console.Write("Patient Name: ");
                patientDetail.PatientName = Console.ReadLine();
                Console.Write("Patient Age: ");
                patientDetail.PatientAge = Convert.ToInt32(Console.ReadLine());

                var departments = new PatientDetail().GetDepartments();
                Console.WriteLine("\nDepartments List\n");
                foreach (var item in departments)
                {
                    Console.WriteLine(item);
                }

                Console.Write("\nChoose the department number from the above list (1-5) : ");
                int option = Convert.ToInt32(Console.ReadLine());
                string department = departments[option - 1].Substring(2);
                bool isValidDoctor = true;
                do
                {


                    List<string> doctors = new PatientDetail().GetDoctors(option);

                    if (doctors.Count > 0)
                    {
                        Console.WriteLine("\nDoctors in the {0} deartment\n", department);
                        foreach (var item in doctors)
                        {
                            Console.WriteLine(item);
                        }

                        Console.Write("\nDoctor Name : ");

                        doctorname = Console.ReadLine();

                        if (!doctors.Contains(doctorname))
                        {
                            isValidDoctor = false;
                            Console.WriteLine("{0} not found in our list", doctorname);
                        }
                        else
                        {
                            isValidDoctor = true;
                        }

                    }

                } while (!isValidDoctor);

                do
                {
                    Console.Write("\nAppointment Request Date (MM/dd/yyyy) : ");

                    DateTime appointmentRequestDate = Convert.ToDateTime(Console.ReadLine());
                    //DateTime.TryParseExact(Console.ReadLine(),"MM/dd/yyyy",null,DateTimeStyles.None,out appointmentRequestDate);

                    //Validate the appointmentRequestDate and print appropriate message
                    AppointmentDateVerification adv = new AppointmentDateVerification();

                    string ard = adv.CheckAppointmentRequestDate(appointmentRequestDate);
                    if (ard == "Appointment Confirmed")
                    {
                        Console.WriteLine(ard);
                        Random rand = new Random();
                        Console.WriteLine("Patient Id - " + rand.Next(0, int.MaxValue));
                        Console.WriteLine("Please Contact " + doctorname + " on " + appointmentRequestDate.ToString("MM/dd/yyyy"));
                        isValidAppointmentDate = true;

                    }
                    else
                    {
                        Console.WriteLine(ard);
                        isValidAppointmentDate = false;
                    }

                } while (!isValidAppointmentDate);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
