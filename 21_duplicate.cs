using System;

class duplicate
{
    static void Main()
    {
        Console.Write("Enter Your row size: ");
        int rw = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Column size: ");
        int clmn = Convert.ToInt32(Console.ReadLine());

        int[,] arr2d = new int[rw, clmn];
        int[] tempAr = new int[rw * clmn];

       
        for (int i = 0; i < rw; i++)
        {
            for (int j = 0; j < clmn; j++)
            {
                Console.Write("Enter value arr2d[{0},{1}]: ",i,j);
                arr2d[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

      
        int index = 0;
        for (int i = 0; i < rw; i++)
        {
            for (int j = 0; j < clmn; j++)
            {
                tempAr[index++] = arr2d[i, j];
            }
        }
        for (int i = 0; i < rw; i++)
        {
            for (int j = 0; j < clmn; j++)
            {
                Console.Write(arr2d[i, j] + "\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < tempAr.Length; i++)
        {
            if (tempAr[i] == -1)
                continue;

            int count = 1;

            for (int j = i + 1; j < tempAr.Length; j++)
            {
                if (tempAr[i] == tempAr[j])
                {
                    count++;
                    tempAr[j] = -1;
                }
            }

            if (count > 1)
            {
                Console.WriteLine(tempAr[i] + " count " + count);
            }
        }
    }
}