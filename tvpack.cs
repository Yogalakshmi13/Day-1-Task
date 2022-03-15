using System;
class channel
{
public static void Main()
{
Console.WriteLine("Select a package :");

string package=Console.ReadLine();



switch(package)
{

case "packageA":

Console.WriteLine("South Special" + "\n" + "Children's Club" + "\n" +"Movies" +"\n" + "Rate=$250");
break;

case "packageB":


Console.WriteLine("News" + "\n" + "Sports" + "\n" +"Movies" +"\n" + "Regional-2" +"\n" +"Rate=$450");
break;

case "packageC":


Console.WriteLine("Discovery" + "\n" + "History" + "\n" +"National" +"\n" + "Rate=$350");
break;


default:

Console.WriteLine("Please enter a valid package!!!");
break;

}
}
}