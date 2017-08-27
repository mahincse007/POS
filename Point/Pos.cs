using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Pos
    {
        private int itemInput ;
        private int quantityInput;
        private int[] userQuantity = new int[] {0, 0, 0}; 

        string[] items = new string[]{"Pen", "Shirt", "Cap" };
        int[] price = new int[] {5, 100, 50 }; 

        public void Start()
        {
            Console.WriteLine("\nSelect your product \n");
            Console.WriteLine("No \t Item \t Price ");

            int counter = 1; 
            foreach(var item in items)
            {
                Console.WriteLine(counter+". \t "+ item  + " \t "+ price[counter - 1] );
                counter++;
            }
            Console.WriteLine("0. \t to checkout\n");
            Userinput();
        }

        public void Userinput()
        {
            Console.WriteLine("\nInput Item");
            itemInput = Int32.Parse(Console.ReadLine());

            if(itemInput == 0){ CheckOut(); }

            Console.WriteLine("\nInput quantity");
            quantityInput = Int32.Parse(Console.ReadLine());
            UpdateCart();
        }

        public void UpdateCart()
        {
            userQuantity[itemInput - 1] = userQuantity[itemInput - 1] + quantityInput;
            Start();
        }

        public void CheckOut()
        {
            var count = 0;
            double total = 0; 

            Console.WriteLine("\nYou chose the following products: ");
            Console.WriteLine("\nNo \t Item \t Price \t Quantity \t Total");
            foreach (var item in userQuantity)
            {
                if(item == 0 ){ count++; continue; }
                Console.WriteLine(count+1 +". \t "+ items[count] + " \t " + price[count] + " \t " + item +" \t\t "+ price[count] * item);
                
                total += (price[count] * item);
                count++;
            }
            Console.WriteLine("\n\nTotal Price "+ total+"\n\n\n");
            Start();
        }
    }
}
