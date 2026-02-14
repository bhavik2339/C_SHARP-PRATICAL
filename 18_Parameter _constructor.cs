using System;
class demo
{
	static void Main()
	{
		xyz obj1=new xyz(3,2);
		xyz obj2=new xyz(5,3);
		Console.ReadLine();
	}
}
public class xyz
{
	public xyz(int a,int b)
	{
		Console.WriteLine("hellow class "+a+b);
	}
}
