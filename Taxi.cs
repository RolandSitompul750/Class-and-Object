using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject_TAXI_
{
    class Taxi
    {
        private readonly bool OnDuty;

        public string DriverName { get; set; }
        public bool Onduty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : no");
            }
            Console.WriteLine("NumPassenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }

}
