using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appoinment_Booking
{
    class PatientDetail
    {
        public string PatientName
        {
            set; get;
        }
        public int PatientAge
        {
            set; get;
        }

        public List<string> GetDepartments()
        {
            List<string> deptli = new List<string>()
            {
                "ENT","Gynecology","Cardiology","Neurology","Nephrology"
            };

            return deptli;
        }

        public List<string> GetDoctors(int option)
        {
            List<string> docli = new List<string>();
            switch (option)
            {
                case 1:
                    docli.Add("Dr. Murugadoss");
                    docli.Add("Dr. Kalaivani");
                    break;

                case 2:
                    docli.Add("Dr. Abirami");
                    docli.Add("Dr. Lakshmi");
                    docli.Add("Dr. Revathi");
                    break;

                case 3:
                    docli.Add("Dr. Amudhan");
                    docli.Add("Dr. Gunaseelan");
                    docli.Add("Dr. Agarwal");
                    break;

                case 4:
                    docli.Add("Dr. Natarajan");
                    docli.Add("Dr. Nanda");
                    docli.Add("Dr. Keerthi");
                    break;


                case 5:
                    docli.Add("Dr. Ashirvatham");
                    docli.Add("Dr. Cherian");
                    docli.Add("Dr. Ashwath");
                    docli.Add("Dr. Ram");
                    break;
            }
            return docli;
        }
    
}
}
