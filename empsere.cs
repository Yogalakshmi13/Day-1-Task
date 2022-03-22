using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Console2
{
    [Serializable]
    public class Employ
    {
        public int eid = 3124;
        public String Name = "YogaLakshmi";
        public string Gender = "Female";
        public int age = 21;
    }
    internal class empsere
    {


            public void SeritoFile()
            {
                Employ eobj= new Employ();
                FileStream fs = new FileStream("Employ.txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter f = new BinaryFormatter();
                 f.Serialize(fs, eobj);
                fs.Close();
            }

            public void DeserialData()
            {
                FileStream fs = new FileStream("Employ.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter f = new BinaryFormatter();
                Employ emp = (Employ)f.Deserialize(fs);
                Console.WriteLine(emp.eid);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Gender);
                Console.WriteLine(emp.age);
            }

            public static void Main()
            {
                empsere obj = new empsere();
                obj.SeritoFile();
                obj.DeserialData();
                Console.Read();
            }

        }
    }