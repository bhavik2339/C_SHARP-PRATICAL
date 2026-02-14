using System;
class demo
{
	static void Main(string[] args)
	{
		int []a=new int[3];
		a[0]=3;
		a[1]=5;
		a[2]=7;
		Console.WriteLine("size of array "+a.Length);
		for(int i=0;i<a.Length;i++)
		{
			Console.WriteLine(a[i]);
		}
		Console.ReadLine();
	}
}