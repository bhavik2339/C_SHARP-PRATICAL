using System;
class demo
{
	static void Main()
	{
		xyz x=new xyz();
		xyz y=new xyz(2);
		Console.ReadLine();
	}
}
public class xyz
{
	public xyz()
	{
		Console.WriteLine("hellow class");
	}
	public xyz(int a)
	{
		Console.WriteLine("hellow class");
	}
}