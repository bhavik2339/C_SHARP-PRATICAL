using System;
class demo
{
	static void Main()
	{
		xyz obj1=new xyz(5);
		xyz obj2=new xyz(obj1);
		Console.ReadLine();
	}	

}
public class xyz
{
	public xyz(int a)
	{
		Console.WriteLine("hello parameter ");
	}
	public xyz (xyz temp)
	{
		Console.WriteLine("hello copy");
	}
}