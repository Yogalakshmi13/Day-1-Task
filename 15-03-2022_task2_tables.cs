using System;
class Tables
{
public static void Main()
{
int i;

Console.WriteLine("Enter a multiplication number:");
i=Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for(int j=1;j<=20;j++)
{
Console.WriteLine("{0} * {1}= {2}",i,j,i*j);
}
}
}
