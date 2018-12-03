using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Holly Maxwell
             * 07/22/18
             * Lists
                         
             */
            //Welcome to the program
            Console.WriteLine("Welcome to shopping list, below you will find the contents of the list\r\nand the corresponding prices.\r\n");
            //item List
            List<string> shoppingList = new List<string>() { "peach", "pineapple", "apple", "grape", "honeydew", "strawberry", "mango", "cucumber" };

            //price List
            List<decimal> priceList = new List<decimal>() { 1.75m, 3.45m, 2.50m, 4.65m, 3.20m, 5.45m, 4.35m, 1.25m };

            CombineTheLists(shoppingList, priceList);
            //Tell the user the list is changing
            Console.WriteLine("We'll be making some changes to the shopping list, changes are shown below.\r\n");
            
            //Remove items from the lists
            shoppingList.Remove("peach");
            shoppingList.Remove("pineapple");
            priceList.Remove(1.75m);
            priceList.Remove(3.45m);

            //Insert 1 item into the lists
            shoppingList.Insert(0, "banana");
            priceList.Insert(0, 0.50m);

            //Function call with updated lists
            CombineTheLists(shoppingList, priceList);
            



        }
        //Creating function to call upon to combine the lists
        public static void CombineTheLists (List<string> shop, List<decimal> price)
        {

            for (int i=0; i < shop.Count; i++)
            {



                Console.WriteLine("The {0} costs {1}.", shop[i], price[i].ToString("c"));


            }


        }
    }
}
