using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SimpleTask
{
        class Customer
        {
            public void Insert()
            {
                SqlConnection con = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
            
                SqlCommand cmd = new SqlCommand("Select CustID, CustName, Gender,DoB,Contactno,EmailID,City from Tbl_Customers", con);
                con.Open();
                SqlDataReader dr= cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("CustomerID: " + dr[0] + "CustomerName " + dr[1] + "Gender:" + dr[2] + "DoB: " + dr[3] + "ContactNo: " + dr[4] + "EmailID: " + dr[5] + "City: " +dr[6]);
                }
                con.Close();
               
            }

            public void checkCustID(int CustID)
            {
                SqlConnection con = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
                
                SqlCommand cmd = new SqlCommand("select CustName from Tbl_Customers where CustID= " + CustID + " ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("CustomerName: " + dr[0] );
                }

                Console.Read();
                con.Close();

            if(CustID==101)
            {
                Console.WriteLine("Welcome to S.M.Super Market!!!!!");
                SqlCommand cmd1 = new SqlCommand("select ProdID, ProdName,Price,PurchaseDate,DateofExpiry from Tbl_Products", con);
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while(dr1.Read())
                {
                    Console.WriteLine("ProductID: " + dr1[0] + "productName " + dr1[1] + "Price:" + dr1[2] + "Dateofpurchase: " + dr1[3] + "ExpiryDate: " + dr1[4]);
                }
            }

            else if (CustID == 102 || CustID==103)
            {
                Console.WriteLine("Welcome to S.M. Super Market!!!!!");
                SqlCommand cmd1 = new SqlCommand("select ProdID, ProdName,Price,PurchaseDate,DateofExpiry from Tbl_Products", con);
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Console.WriteLine("ProductID: " + dr1[0] + "productName " + dr1[1] + "Price:" + dr1[2] + "Dateofpurchase: " + dr1[3] + "ExpiryDate: " + dr1[4]);
                }
            }

            else if (CustID == 104 || CustID == 105)
            {
                Console.WriteLine("Welcome to S.M. Super Market!!!!!");
                SqlCommand cmd1 = new SqlCommand("select ProdID, ProdName,Price,PurchaseDate,DateofExpiry from Tbl_Products", con);
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Console.WriteLine("ProductID: " + dr1[0] + "productName " + dr1[1] + "Price:" + dr1[2] + "Dateofpurchase: " + dr1[3] + "ExpiryDate: " + dr1[4]);
                }
            }

            else
            {
                Console.WriteLine("Your not a regular customer!!! can you please fill your details!!!!");
                Console.WriteLine("Enter Customer Name: ");
                string CustName = Console.ReadLine();
                Console.WriteLine("Enter Gender: ");
                string Gender = Console.ReadLine();
                Console.WriteLine("Enter DoB: ");
                string DoB = Console.ReadLine();
                Console.WriteLine("Enter Contact number: ");
                string Contactno = Console.ReadLine();
                Console.WriteLine("Enter EmailId: ");
                string EmailID = Console.ReadLine();
                Console.WriteLine("Enter Your City: ");
                string City = Console.ReadLine();
                SqlConnection con1 = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
                SqlCommand cmd2 = new SqlCommand("insert into Tbl_Customers values(Customername:'" + CustName + "', gender:'" + Gender + "',Date of birth:'" + Contactno + "',EmailId:'" + EmailID + "',city: '" + City+"')", con1);
                con1.Open();
                cmd2.ExecuteNonQuery();
                con1.Close();

            }

        }

        }

    class Product
    {
        public void ReadData()
        {
            SqlConnection con = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("Select ProdID,ProdName,Price,PurchaseDate,DateofExpiry from Tbl_Products", con);
            con.Open();
            SqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                Console.WriteLine("ProductID: " + Dr[0] + "productName " + Dr[1] + "Price:" + Dr[2] + "Dateofpurchase: " + Dr[3] + "ExpiryDate: " + Dr[4]);
            }
            con.Close();
        }
    }
    class Bill
    { 
    public void Totalamt()
     {
            SqlConnection con = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Products", con);
            con.Open();
            
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("ProductID: " + dr[0] + "ProductName: " + dr[1] + "Price: " + dr[2]);
            }
            Console.Read();
            con.Close();

            Console.WriteLine("Enter The ProductId: ");
            int ProdID = Convert.ToInt32(Console.ReadLine());


            switch (ProdID)
            {
                case 1001:

                    Console.WriteLine("You Purchase a Sweets!!!!");
                    Console.WriteLine("Enter the Quantity:");
                    int Quantity = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con1 = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
                    SqlCommand cmd1 = new SqlCommand("Select Price*" + Quantity + " from Tbl_Products where ProdID= " + ProdID + " ", con1);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        int Amount = Convert.ToInt32(dr1[0]);
                        Console.WriteLine("TotalAmount: " + Amount);
                    }
                    Console.Read();
                    con1.Close();
                    break;

                case 1002:
                    Console.WriteLine("You Purchase a Fruits!!!!");
                    Console.WriteLine("Enter the Quantity:");
                    int Quantity1 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
                    SqlCommand cmd2 = new SqlCommand("Select Price*" + Quantity1 + " from Tbl_Products where ProdID= " + ProdID + " ", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int Amount1 = Convert.ToInt32(dr2[0]);
                        Console.WriteLine("TotalAmount: " + Amount1);
                    }
                    Console.Read();
                    con2.Close();
                    break;

                case 1003:
                    Console.WriteLine("You Purchase a Snacks!!!!");
                    Console.WriteLine("Enter the Quantity:");
                    int Quantity2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
                    SqlCommand cmd3 = new SqlCommand("Select Price*" + Quantity2 + " from Tbl_Products where ProdID= " + ProdID + " ", con3);
                    con3.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int Amount2 = Convert.ToInt32(dr3[0]);
                        Console.WriteLine("TotalAmount: " + Amount2);
                    }
                    Console.Read();
                    con3.Close();
                    break;
           
                case 1004:
                         Console.WriteLine("You Purchase a Fruits!!!!");
                        Console.WriteLine("Enter the Quantity:");
                        int Quantity3 = Convert.ToInt32(Console.ReadLine());
                        SqlConnection con4 = new SqlConnection("Data source=Lenovo-PC\\TRAINING; database= Store; user id=sa; password=P@ssw0rd");
                        SqlCommand cmd4 = new SqlCommand("Select Price*" + Quantity3 + " from Tbl_Products where ProdID= " + ProdID + " ", con4);
                        con4.Open();
                        cmd4.ExecuteNonQuery();
                        SqlDataReader dr4 = cmd4.ExecuteReader();
                        while (dr4.Read())
                        {
                            int Amount3 = Convert.ToInt32(dr4[0]);
                            Console.WriteLine("TotalAmount: " + Amount3);
                        }
                        Console.Read();
                        con4.Close();
                        break;
                    
                 default:
                        Console.WriteLine("Invalid Data");
                        break;
            }
            
        }
    }

    class Data
    {
            public static void Main()
            {


            //Customer ob1 = new Customer();

            //ob1.Insert();
            //Console.WriteLine("Enter CustomerID:");
            //int CustID = Convert.ToInt32(Console.ReadLine());
            //ob1.checkCustID(CustID);

            //Product ob2 = new Product();
            //ob1.ReadData();
           
            //Console.WriteLine("Enter the Quantity:");
            //int Quantity = Convert.ToInt32(Console.ReadLine());
            Bill ob3 = new Bill();
            //Console.WriteLine("Enter ProductID:");
            //int ProdID = Convert.ToInt32(Console.ReadLine());
            ob3.Totalamt();
        }

    }

}
