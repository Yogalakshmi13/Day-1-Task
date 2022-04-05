using System;
class addsub
{
int num1,num2,res;
public void Add()
{

Console.WriteLine("Enter 2 numbers:");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());

res=num1+num2;
Console.WriteLine(res);
}

public void Sub()
{

Console.WriteLine("Enter 2 numbers:");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());

res=num1-num2;
Console.WriteLine(res);
}
}

class muldiv:addsub
{
int num1,num2,res;
public void Mul()
{

Console.WriteLine("Enter 2 numbers:");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());

res=num1*num2;
Console.WriteLine(res);
}

public void Div()
{

Console.WriteLine("Enter 2 numbers:");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());

res=num1/num2;
Console.WriteLine(res);
}
}

class operations
{
public static void Main()
{

addsub obj=new addsub();
obj.Add();
obj.Sub();

muldiv obj1=new muldiv();
obj1.Mul();
obj1.Div();
}
}
