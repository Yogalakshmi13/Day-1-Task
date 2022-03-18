using System;
class employee
{
int eid,yoexp;
string name,gender;


public void emp()
{
Console.WriteLine("Enter your name:");
name=Console.ReadLine();

Console.WriteLine("Enter your employee id:");
eid=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your gender:");
gender=Console.ReadLine();

Console.WriteLine("Enter years of experience:");
yoexp=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Name: "+name);
Console.WriteLine("Emp.Id: "+eid);
Console.WriteLine("Gender: "+gender);
Console.WriteLine("Years of experience: "+yoexp);

}
}

class details : employee
{

public void det()
{


Console.WriteLine("Enter your departments:");
string depts=Console.ReadLine();

if(depts=="sales marketing")
{
Console.WriteLine("Enter your salary:");
int sal=Convert.ToInt32(Console.ReadLine());

int tot=sal*(20/100);
Console.WriteLine("Your salary with bonus is "+sal+tot);
}

else if(depts=="production departments")
{
Console.WriteLine("Enter your salary:");
int sal=Convert.ToInt32(Console.ReadLine());
int tot=sal*(10/100);
Console.WriteLine("Your salary with bonus is "+sal+tot);
}
else
{
Console.WriteLine("Please enter a valid departments");
}

}

public static void Main()
{
details dobj=new details();
dobj.emp();
dobj.det();
}
}