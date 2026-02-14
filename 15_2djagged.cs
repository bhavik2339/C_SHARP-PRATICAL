using System;
class Jagged_2D_Arr{
	static void Main(){
		int [][] a = new int[4][];
		a[0] = new int[2];
		a[1] = new int[3];
		a[2] = new int[4];
		
		a[0][0] = 1;
		a[0][1] = 2;
		a[1][0] = 3;
		a[1][1] = 4;
		a[1][2] = 5;
		a[2][0] = 6;
		a[2][1] = 7;
		a[2][2] = 8;
		a[2][3] = 9;
		
		foreach(int[] b in a)
		{
			foreach(int c in b)
			{
				Console.WriteLine(c+" ");
			}
		}
		Console.WriteLine();
	}
}
