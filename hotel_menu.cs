using System;
using System.Collections.Generic;

class hotel_menu
{
    public static void Main()
    {
        List<string> items =new List<string>();
        List<int> qty =new List<int>();
        List<int> prices =new List<int>();

        int total =0;
        string res="";

        Console.WriteLine("\n<----------MENU---------->\n");
        Console.WriteLine("1. Panir \t Price=30");
        Console.WriteLine("2. Pani Puri \t Price=40");
        Console.WriteLine("3. Rotli \t Price=50");
        Console.WriteLine("4. Papad \t Price=60");
        Console.WriteLine("5. Athanu \t Price=70");
		Console.WriteLine("\n<---------END----------->\n");
        do
        {
            Console.Write("\nEnter Your Choice In Number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string item = "";
            int price = 0;

            switch(choice)
            {
                case 1:
				item ="Panir"; price =30;
				break;
				
                case 2:
				item ="Pani Puri"; price =40; 
				break;
				
                case 3: 
				item ="Rotli"; price =50; 
				break;
				
                case 4:
				item ="Papad"; price =60; 
				break;
				
                case 5: 
				item ="Athanu"; price =70; 
				break;
				
                default:
                    Console.WriteLine("Enter Number Between 1 To 5");
                    continue;
            }

            Console.WriteLine("You Selected: " + item);
            Console.WriteLine("Price: " + price);
            Console.Write("Enter Quantity: ");
            int q=Convert.ToInt32(Console.ReadLine());

            // check if item already exists
            int index=items.IndexOf(item);

            if (index !=-1)
            {
                qty[index]+=q;// old product plus add 
            }
            else
            {	// new product add 
                items.Add(item);
                qty.Add(q);
                prices.Add(price);	
            }

            int ml=q * price;
            total +=ml;

            Console.WriteLine("Total Price For {0}: {1}", item, ml);

            Console.Write("\nEnter 'y' Repeat Menu Or 'n' Exit: ");
            res = Console.ReadLine();

        } while(res == "y");

        //your final bill
        Console.WriteLine("-------------YOUR BILL-------------------");
        for(int i = 0;i<items.Count;i++)
        {
            Console.WriteLine(items[i] +"  Qty: " + qty[i] +"  Price: " + prices[i] +"  Total: " + (qty[i] * prices[i]));
        }
		Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Total Price with all item is: " + total);
		Console.WriteLine("-----------------------------------------");
    }
}