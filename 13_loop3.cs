using System;
class bhavik
{
	static void Main()
	{
		int[]a=new int[5]{2,5,5,1,6};
		
		foreach(int v in a)
		{
			Console.WriteLine(a[v]);
		}
		Console.WriteLine();
		for(int i=0;i<a.Length;i++)
		{
			Console.WriteLine(a[i]);
		}
		Console.WriteLine();
		int w=0;
		while(w<a.Length)
		{
			Console.WriteLine(a[w]);
			w++;
		}
		Console.WriteLine();
	}
}