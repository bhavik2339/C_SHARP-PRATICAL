using System;
class demo
{
	static void Main()
	{
		xyz x=new xyz(5);
		xyz y=new xyz(67);
		x.show();
		y.show();
		Console.ReadLine();
	}
}
public class xyz
{
	int b;
	public xyz(int a)
	{
		b=a;
		Console.WriteLine("hello class " +a);
	}
	public void show()
	{
		Console.WriteLine("value : "+b);
	}
}