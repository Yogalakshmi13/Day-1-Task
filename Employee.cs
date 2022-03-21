using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console1
{
    internal class Employee
    {
        public static void Main()
        {
            Employee employee = new Employee();
            {
                FileStream fs = new FileStream("C:\\yoga\\programming\\Employee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                BinaryWriter bw1 = new BinaryWriter(fs);
                BinaryWriter bw2 = new BinaryWriter(fs);
                BinaryWriter bw3 = new BinaryWriter(fs);
                BinaryWriter bw4 = new BinaryWriter(fs);
                BinaryWriter bw5 = new BinaryWriter(fs);
                BinaryWriter bw6 = new BinaryWriter(fs);
                BinaryWriter bw7 = new BinaryWriter(fs);
                bw.Write("E01");
                bw1.Write("Nikshi");
                bw2.Write("23");
                bw3.Write("Female");
                bw4.Write("E02");
                bw5.Write("Yoga");
                bw6.Write("23");
                bw7.Write("Female");
                bw.Flush();
                fs.Close();
                FileStream fs1 = new FileStream(@"C:\yoga\programming\Employee.txt", FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br = new BinaryReader(fs1);
                BinaryReader br1 = new BinaryReader(fs1);
                BinaryReader br2 = new BinaryReader(fs1);
                BinaryReader br3 = new BinaryReader(fs1);
                BinaryReader br4 = new BinaryReader(fs1);
                BinaryReader br5 = new BinaryReader(fs1);
                BinaryReader br6 = new BinaryReader(fs1);
                BinaryReader br7 = new BinaryReader(fs1);
                string str = br.ReadString();
                string str1 = br1.ReadString();
                string str2 = br2.ReadString();
                string str3 = br3.ReadString();
                string str4 = br4.ReadString();
                string str5 = br5.ReadString();
                string str6 = br6.ReadString();
                string str7 = br7.ReadString();
                Console.WriteLine(str);
                Console.WriteLine(str1);
                Console.WriteLine(str2);
                Console.WriteLine(str3);
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str6);
                Console.WriteLine(str7);
                fs1.Close();
                Console.Read();
            }
        }
    }
}
