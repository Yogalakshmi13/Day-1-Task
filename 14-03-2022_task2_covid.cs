using System;
class covid
{
public static void Main()
{

string hist,temp,cough;

Console.WriteLine("Do yoy have travel history?");
hist=Console.ReadLine();



if(hist=="Yes")
{
Console.WriteLine("Do you have temperature?");
temp=Console.ReadLine();

if(temp=="Yes")
{
Console.WriteLine("Do you have cough/sneez?");
cough=Console.ReadLine();

if(cough=="Yes")
{
Console.WriteLine("Swab Test");
}
else
{
Console.WriteLine("Quarantine Fever Medicine");
}
}
else
{
Console.WriteLine("Home Quartine for 28 days");
}

}
else
{
Console.WriteLine("Safe Not Covid-19");
}
}
}
