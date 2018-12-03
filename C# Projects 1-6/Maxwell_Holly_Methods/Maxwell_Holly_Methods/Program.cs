using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Holly Maxwell
             * 07/21/18
             * Methods             
             */

            //Space Cadet

            //Welcome to the program and introducing what the program does
            Console.WriteLine("Welcome to Space Cadet!\r\n\r\nLet's calculate what your weight would be if you were on the surface of the moon!");

            Console.WriteLine("\r\nWhat is your current weight in pounds?");

            //String variable to catch the users input
            string weightString = Console.ReadLine();

            //Create variable to hold the value of weight after it is converted into a double
            double weight;

            while (!double.TryParse(weightString, out weight)) {

                Console.WriteLine("\r\nOops! It looks like you didn't enter a valid input!\r\n\r\nPlease enter your weight.");

                weightString = Console.ReadLine();

            }

            //Call on the function to return a value to be stored in the variable weightOnMoon
            double weightOnMoon = MoonWeight(weight);

            //Report results to the user
            Console.WriteLine("\r\nOk! Here are your results:\r\n");
            Console.WriteLine("On Earth you weigh {0}lbs, but on the moon you weigh {1}lbs.", weight, Math.Round(weightOnMoon, 2));

            /* Test Results:
              1.
              Welcome to Space Cadet!

              Let's calculate what your weight would be if you were on the surface of the moon!

              What is your current weight in pounds?
              160
              
              Ok! Here are your results:

              On Earth you weigh 160lbs, but on the moon you weigh 26.67lbs.
              2.
              Welcome to Space Cadet!

              Let's calculate what your weight would be if you were on the surface of the moon!

              What is your current weight in pounds?
              210
              
              Ok! Here are your results:

              On Earth you weigh 210lbs, but on the moon you weigh 35lbs.
              3.
              Welcome to Space Cadet!

              Let's calculate what your weight would be if you were on the surface of the moon!

              What is your current weight in pounds?
              One Hundred Pounds
              
              Oops! It looks like you didn't enter a valid input!

              Please enter your weight.
              4.
              Welcome to Space Cadet!

              Let's calculate what your weight would be if you were on the surface of the moon!

              What is your current weight in pounds?
              197

              Ok! Here are your results:

              On Earth you weigh 197lbs, but on the moon you weigh 32.83lbs.             
             */

            //Discount Calculator

            //Welcome to the program and introduction to it's function
            Console.WriteLine("\r\nHey! Welcome to Discount Calculator!\r\n");
            Console.WriteLine("Let's calculate the final cost of your two items with discount.\r\n");

            //Prompt the user for cost of item 1
            Console.WriteLine("What is the cost of your first item?");

            //Create variable to store user input for item 1
            string costItem1String = Console.ReadLine();

            //Declare variable to hold value converted from string to decimal
            decimal costItem1;

            //Verify the user's input
            while (!decimal.TryParse(costItem1String, out costItem1))
            {

                Console.WriteLine("\r\nOops! It looks like you didn't enter a valid number.\r\nPlease enter the cost of your first item.");
                costItem1String = Console.ReadLine();

            }

            //Prompt the user for the cost of item 2
            Console.WriteLine("\r\nOk, what is the cost of your second item?");

            //Create variable to store user input for item 2
            string costItem2String = Console.ReadLine();

            //Declare variable to hold value converted from string to decimal
            decimal costItem2;

            //Verify user's input
            while (!decimal.TryParse(costItem2String, out costItem2))
            {

                Console.WriteLine("\r\nOops! It looks like you didn't enter a valid number.\r\nPlease enter the cost of your second item.");
                costItem2String = Console.ReadLine();

            }

            //Prompt the user for a discount percentage
            Console.WriteLine("\r\nGot it! Now, please enter the desired discount. (Do not enter a % symbol)");

            //Create variable to store user input for discount percentage 
            string discountString = Console.ReadLine();

            //Declare variable to hold the converted value
            int discount;

            //Verify the input is a valid number
            while (!int.TryParse(discountString, out discount))
            {

                Console.WriteLine("\r\nOops! It looks like you didn't enter a valid number.\r\nPlease enter the desired discount without a % symbol.");
                discountString = Console.ReadLine();

            }

            //Function call to TotalCost
            decimal totalCost = TotalCost(costItem1, costItem2, discount);

            //Output to the user
            Console.WriteLine("\r\nWith a {0}% discount your total is {1}.", discount, totalCost.ToString("c"));

            /*
               Test Results:
               1.
               Hey! Welcome to Discount Calculator!

               Let's calculate the final cost of your two items with discount.

               What is the cost of your first item?
               10.00

               Ok, what is the cost of your second item?
               15.50

               Got it! Now, please enter the desired discount. (Do not enter a % symbol)
               20

               With a 20% discount your total is $20.40.
               2.
               Hey! Welcome to Discount Calculator!

               Let's calculate the final cost of your two items with discount.

               What is the cost of your first item?
               20.25

               Ok, what is the cost of your second item?
               37.75

               Got it! Now, please enter the desired discount. (Do not enter a % symbol)
               10

               With a 10% discount your total is $52.20.
               3.
               Hey! Welcome to Discount Calculator!

               Let's calculate the final cost of your two items with discount.

               What is the cost of your first item?
               35.72

               Ok, what is the cost of your second item?
               3.00

               Got it! Now, please enter the desired discount. (Do not enter a % symbol)
               15

               With a 15% discount your total is $32.91.

                         
             */

            //Double The Fun

            //Declare and define an integer array
            int[] intArray = new int[] { 11, 22, 44, 5, 6, 10, 33, 14};

            //Call on function
            int[] intArrayDoubled = ArrayDoubler(intArray);

            //Output the arrays to the console
            Console.WriteLine("\r\nYour original array was {0} and now it is doubled it is {1}.", string.Join(", ", intArray), string.Join(", ", intArrayDoubled));

            /*
               Test Results:
               1.
               Your original array was 1, 2, 5, 6, 9 and now it is doubled it is 2, 4, 10, 12, 18.
               2.
               Your original array was 12, 3, 8, 20, 7 and now it is doubled it is 24, 6, 16, 40, 14.
               3.
               Your original array was 11, 22, 44, 5, 6, 10, 33, 14 and now it is doubled it is 22, 44, 88, 10, 12, 20, 66, 28.


              */



        }

        public static double MoonWeight(double wei)
        {

            double weightFunc = wei / 6;

            return weightFunc;

        }

        public static decimal TotalCost(decimal cost1, decimal cost2, decimal dis)
        {
            decimal totalBeforeDiscount = cost1 + cost2;
            decimal total = totalBeforeDiscount - ((dis / 100) * totalBeforeDiscount);

            return total;


        }

        public static int[] ArrayDoubler(int[] intA)
        {

            int[] arrayDoubled = new int[intA.Length];
            for (int i = 0; i < intA.Length; i++)
           {
                
                arrayDoubled[i] = intA[i] * 2;
                

            }


            return arrayDoubled;



        }

      
    }
}
