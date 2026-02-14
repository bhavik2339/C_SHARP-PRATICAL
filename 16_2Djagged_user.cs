using System;
class jagged2Darray
{
	static void Main()
	{
		Console.Write("enter number of rows :");
		int[][] arr=new int[rows][];
		
		for(int i=0;i<rows;i++)
		{
			Console.Write("enter number of columns for rows {i}");
			int cols=Convert.ToInt32(Console.Readline());
			arr[i]=new int[cols];
		}
		
		Console.Write("\n enter elements : ");
		
		for(int i=0:i<rows;i++)
		{
			for(int j=0;j<arr[i].Length;j++)
			{
				Console.write("arr[{i}][{j}] = ");
				
				arr[i][j]=Convert.ToInt32(Console.Readline());
			}
		}
		
		console.writeLine("\n jagged array output : \n");
		
		for(int i=0;i<rows;i++)
		{
			for(int j=0;j<)
		}
	}
}