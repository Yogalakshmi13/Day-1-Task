using System;
class Electricity
{
public static void Main()
{
int units, rate1,rate2,rate3,rate4;
 
Console.WriteLine("Enter the units:");
units=Convert.ToInt32(Console.ReadLine());

if(units>0 && units<200)
{
rate1=(units*2);
Console.WriteLine("Bill: "+rate1);
rate1=Convert.ToInt32(Console.ReadLine());
}
else if(units>=200 && units<=350)
{
rate2=(200*2)+((units-300)*3);
Console.WriteLine("Bill: "+rate2);
rate2=Convert.ToInt32(Console.ReadLine());
}
else if(units>350 && units<=500)
{
rate3=(200*2+150*3)+((units-350)*5);
Console.WriteLine("Bill: "+rate3);
rate3=Convert.ToInt32(Console.ReadLine());
}
else
{
rate4=(200*2+150*3+50*5)+((units-500)*7);
Console.WriteLine("Bill: "+rate4);
rate4=Convert.ToInt32(Console.ReadLine());
}
}
}
