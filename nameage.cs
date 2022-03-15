using System;
class nameage
{
public static void Main()
{

string name;
int age;

Console.WriteLine("Enter Your Name:");
name=Console.ReadLine();

Console.WriteLine("Enter Your Age:");
age=Convert.ToInt32(Console.ReadLine());


for(int i=1;i<age;i++)
{
Console.WriteLine(" Your Name is: "+name);
}
}
}