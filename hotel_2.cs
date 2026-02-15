using System;

class hotel_menu
{
    public static void Main()
    {
        string[] items = new string[10];
        int[] qty = new int[10];
        int[] prices = new int[10];

        int count = 0;
        int total = 0;
        string res = "";

        Console.WriteLine("\n<----------MENU---------->\n");
        Console.WriteLine("1. Panir \t Price=30");
        Console.WriteLine("2. Pani Puri \t Price=40");
        Console.WriteLine("3. Rotli \t Price=50");
        Console.WriteLine("4. Papad \t Price=60");
        Console.WriteLine("5. Athanu \t Price=70");
        Console.WriteLine("\n<---------END----------->\n");

        do
        {
            Console.Write("Enter Your Choice In Number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string item = "";
            int price = 0;

            switch (choice)
            {
                case 1: 
				item = "Panir"; price = 30; 
				break;
				
                case 2: 
				item = "Pani Puri"; price = 40; 
				break;
				
                case 3: 
				item = "Rotli"; price = 50; 
				break;
				
                case 4: 
				item = "Papad"; price = 60; 
				break;
				
                case 5: 
				item = "Athanu"; price = 70; 
				break;
				
                default:
                    Console.WriteLine("Enter Number Between 1 To 5");
                    continue;
            }

            Console.WriteLine("You Selected: " + item);
            Console.WriteLine("Price: " + price);
            Console.Write("Enter Quantity: ");
            int q = Convert.ToInt32(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                qty[index] += q;
            }
            else
            {
                items[count] = item;
                qty[count] = q;
                prices[count] = price;
                count++;
            }

            int ml = q * price;
            total += ml;

            Console.WriteLine("Total Price For {0}: {1}", item, ml);

            Console.Write("Enter 'y' Repeat Menu Or 'n' Exit: ");
            res = Console.ReadLine();

        } while (res == "y");

        Console.WriteLine("-------------YOUR BILL-------------------");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(items[i] + "  Qty: " + qty[i] + "  Price: " + prices[i] +
                "  Total: " + (qty[i] * prices[i]));
        }

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Total Price with all item is: " + total);
        Console.WriteLine("-----------------------------------------");
    }
}
