using System;
abstract class Arithmetic
{
public abstract void Add();
public abstract void Sub();
public abstract void Mul();
public abstract void Div();
}
class Calculator: Arithmetic
{
public override void Add()
{
Console.WriteLine("Enter two numbers:");
int number1,number2, result;
number1=Convert.ToInt32(Console.ReadLine());
number2=Convert.ToInt32(Console.ReadLine());
result=number1+number2;
Console.WriteLine("The Addition of two numbers: "+result);
}
public override void Sub()
{
Console.WriteLine("Enter two numbers:");
int number1,number2, result;
number1=Convert.ToInt32(Console.ReadLine());
number2=Convert.ToInt32(Console.ReadLine());
result=number1-number2;
Console.WriteLine("The Subtraction of two numbers: "+result);
}
public override void Mul()
{
Console.WriteLine("Enter two numbers:");
int number1,number2, result;
number1=Convert.ToInt32(Console.ReadLine());
number2=Convert.ToInt32(Console.ReadLine());
result=number1*number2;
Console.WriteLine("The Multiplication of two numbers: "+result);
}
public override void Div()
{
Console.WriteLine("Enter two numbers:");
int number1,number2, result;
number1=Convert.ToInt32(Console.ReadLine());
number2=Convert.ToInt32(Console.ReadLine());
result=number1/number2;
Console.WriteLine("The Division of two numbers:"+result);
}


public static void Main()
{
Calculator calc=new Calculator();
calc.Add();
calc.Sub();
calc.Mul();
calc.Div();
}
}
