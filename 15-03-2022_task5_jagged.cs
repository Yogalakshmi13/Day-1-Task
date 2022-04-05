using System;
class jagged
{
public static void Main()
{
string[][]Prdlist=new string[3][];

Prdlist[0]=new string[]{"Biscuit","Biscuit","Biscuit","Biscuit"};
Prdlist[1]=new string[]{"Chocolate","Chocolate","Chocolate","Chocolate","Chocolate"};
Prdlist[2]=new string[]{"Drinks","Drinks","Drinks","Drinks","Drinks","Drinks"};

for(int i=0;i<Prdlist.Length;i++)
{
	for(int j=0;j<Prdlist[i].Length;j++)
	Console.Write(Prdlist[i][j] + "\t");
	Console.WriteLine();


}

}
}
