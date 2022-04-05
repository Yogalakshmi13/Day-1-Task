using System;
interface Membership
{
void Silver();
void Gold();
void Platinum();
}
class Packages:Membership
{
public void Silver()
{
Console.WriteLine("SILVER");
Console.WriteLine("3 DAYS ACCOMODATION AT RESORT");
}
public void Gold()
{
Console.WriteLine("GOLD");
Console.WriteLine("5 DAYS ACCOMODATION AT RESORT AND 2 DINNERS ON THE HOUSE");
}
public void Platinum()
{
Console.WriteLine("PLATINUM");
Console.WriteLine("7 DAYS ACCOMODATION AT RESORT AND 5 DINNERS ON THE HOUSE");
}
}
class implements
{
public static void Main()
{
Packages pack=new Packages();
pack.Silver();
pack.Gold();
pack.Platinum();
}
}
