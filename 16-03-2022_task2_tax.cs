using System;

class Vat
{
public virtual void calculateTax(int num)
{
int vat;
vat=(num*20/100);
Console.WriteLine("VAT= "+vat);
}
}

class Gst:Vat
{
public override void calculateTax(int num)
{
int gst;
gst=(num*12/100);
Console.WriteLine("GST= "+gst);
}
}

class Tax
{
public static void Main()
{
int num;
Console.WriteLine("Enter the price:");
num=Convert.ToInt32(Console.ReadLine());

Vat obj=new Vat();
obj.calculateTax(num);

Gst obj1=new Gst();
obj1.calculateTax(num);


}
}
