using System;
class student
{
public static void Main()
{
int []marks=new int[5];
Console.WriteLine("Enter a Student name:");
string name=Console.ReadLine();
int sum=0;

Console.WriteLine("Enter the marks:");


for(int i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
sum=sum+marks[i];

}
Console.WriteLine("Sum= " +sum);
int percentage=(sum/5);

Console.WriteLine("Percentage= " +percentage+ "%");

}

}
