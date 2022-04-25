using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class Doctor
    {
        public static void Main()
        {
            IList<doctor> doctData = new List<doctor>()
            {
                new doctor() { doctorID = 1, doctorName = "Michael", age = 34, splID=1 },
                new doctor() { doctorID = 2, doctorName = "Jenifer", age = 43, splID=2},
                new doctor() { doctorID = 3, doctorName = "Murthy", age = 38,splID=1},
                new doctor() { doctorID = 4, doctorName = "Madhavi", age = 41,splID=3},
                new doctor() { doctorID = 5, doctorName = "Devi", age = 44, splID=2},
                new doctor() { doctorID = 6, doctorName = "Manjula", age = 46,splID=1}

            };
            IList<specialist> spldata = new List<specialist>()
            {
                new specialist(){ specialisation="Pedietrician", splID=1},
                new specialist(){ specialisation="Dentist", splID=2},
                new specialist(){ specialisation="Dermatologist", splID=3}
            };

            var joindata = doctData.Join(
                           spldata, 
                       doct=> doct.splID,
                       sp=>sp.splID,
                        (doct,sp)=>new
                        {
                            doctorName = doct.doctorName,
                            specialisation = sp.specialisation
                        });

            foreach(var item in joindata)
            {
                Console.WriteLine(item.doctorName+" "+item.specialisation);

            }
        }
    }
        class doctor
        {
            public int doctorID { get; set; }
            public string doctorName { get; set; }
            public int age { get; set; }
            public int splID { get; set; }
        }
        class specialist
        {
            public string specialisation { get; set; }
            public int splID { get; set; }
        }
    
}
