using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appoinment_Booking
{
    class AppointmentDateVerification
    {
        public string CheckAppointmentRequestDate(DateTime appointmentRequestDate)
        {
            DateTime dt = DateTime.Today;
            string str = dt.ToString("MM/dd/yyyy");

            DateTime dt1 = Convert.ToDateTime(str);


            if (dt1 < appointmentRequestDate)
            {
                if (dt.Year == appointmentRequestDate.Year)
                {
                    if (appointmentRequestDate.DayOfWeek != DayOfWeek.Monday)
                    {
                        return "Appointment Confirmed";
                    }
                    else
                    {
                        return ("Sorry!!! Appointment cannot be given on Monday!");
                    }
                }
                else
                {
                    return ("Appointment Rejected, You can book appointment only for the current year!");
                }
            }
            else
            {
                return ("Appointment Rejected, Date must be a future date!");
            }
        }
    }
}
