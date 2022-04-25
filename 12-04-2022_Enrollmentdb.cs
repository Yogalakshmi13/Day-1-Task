using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace dbase1
{
    class Enrollmentdb
    {
        
        public void create()
        {
            SqlConnection con = new SqlConnection("data source=Lenovo-PC\\TRAINING; database=Details; user id=sa; password=P@ssw0rd");
            con.Open();
            SqlCommand cmd = new SqlCommand("create table enroll(Sno int, Fname varchar(20), Lname varchar(20), Emailid varchar(40))", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created Successully");
            con.Close();
        }
        public void insert(int Sno,string Fname,string Lname,string Emailid)
        {
            SqlConnection con = new SqlConnection("data source=Lenovo-PC\\TRAINING; database=Details; user id=sa; password=P@ssw0rd");
            con.Open();
            string sqlqry = "insert enroll values(" + Sno + ",'" + Fname + "','" + Lname + "','" + Emailid + "')";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Row inserted successful");
            con.Close();
        }
        public void InsSP(int Sno, string Fname, string Lname, string Emailid)
        {
            SqlConnection con = new SqlConnection("data source=Lenovo-PC\\TRAINING; database=Details; user id=sa; password=P@ssw0rd");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_InstTest", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@Sno",SqlDbType.Int).Value = Sno;
            cmd.Parameters.Add("@Fname",SqlDbType.VarChar).Value = Fname;
            cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = Lname;
            cmd.Parameters.Add("@Emailid",SqlDbType.VarChar).Value = Emailid;
            
            cmd.ExecuteNonQuery();
            con.Close();
        }

            public void update()
        {
            SqlConnection con = new SqlConnection("data source=Lenovo-PC\\TRAINING; database=Details; user id=sa; password=P@ssw0rd");
            con.Open();
            string sqlqry = "update enroll Set Sno=1006 where Fname='Harika'";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Updated successfully");
            
        }

        public void delete()
        {
            SqlConnection con = new SqlConnection("data source=Lenovo-PC\\TRAINING; database=Details; user id=sa; password=P@ssw0rd");
            con.Open();
            string sqlqry1 = "delete enroll where Sno=1005";
            SqlCommand cmd = new SqlCommand(sqlqry1, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Deleted successfully");
        }
        public static void Main(string[] args)
        {
            Enrollmentdb obj1 = new Enrollmentdb();
            //obj1.create();
            //Console.WriteLine("Enter Sno:");
            //int Sno = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter FirstName:");
            //string Fname = Console.ReadLine();
            //Console.WriteLine("Enter LastName:");
            //string Lname = Console.ReadLine();
            //Console.WriteLine("Enter Email ID:");
            //string Emailid = Console.ReadLine();
            ////obj1.insert(Sno,Fname,Lname,Emailid);
            //obj1.InsSP(Sno, Fname,Lname,Emailid);
            obj1.update();
            //obj1.delete();
        }
    }
}
