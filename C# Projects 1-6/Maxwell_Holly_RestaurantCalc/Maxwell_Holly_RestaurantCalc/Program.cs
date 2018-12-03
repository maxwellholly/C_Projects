using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_RestaurantCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Holly Maxwell
            SDI Assignment: Tip Calculator
            Sect 201807 01 
            07/01/18 
            */

            //Beginning with a greeting
            //Testing a few ways of creating a new line of text, both with \r\n and simply using a new WriteLine
            
            Console.WriteLine("Hello, thank you for dining with us! \r\nWelcome to our check calculator! \r\nIt looks like there were 3 guests in your party tonight!");

            Console.WriteLine("Let's calculate each tip and the total for your party!");

            Console.WriteLine("Let's start with Guest 1, what is your check total before tip?\r\n(Do not enter a $ with your value)");

            /*At first I had the user input their number of guests and used that input (after conversion) to create an array based on the number of 
              guests in their party, but I'm not sure how to code the program so that the input prompts terminate once the array has been 'maxed' out
              or if that's even possible with the array. So, I created the tip calculator with the assumption that there are always 3 guests.
            */
            
            //Creating variable guestOne for the user's input of their check total before tip
            string guestOne = Console.ReadLine();

            //Guest 1 total before tip converted to decimal
            decimal guestOneBT = decimal.Parse(guestOne);

            Console.WriteLine("Perfect!\r\nNow, how much would you like to leave for a tip?\r\nPlease input a value between 1-100 and hit enter.\r\n(Do not enter a % with your value)");

            //Creating variable tipGuestOne for the user's desired tip percentage
            string tipGuestOne = Console.ReadLine();

            //Guest 1 tip percentage converted to decimal
            decimal tipGuestOneParsed = decimal.Parse(tipGuestOne);

            //Guest 1 total calculation
            decimal guestOneTotal = Math.Round(((tipGuestOneParsed / 100) * guestOneBT) + guestOneBT, 2);

            Console.WriteLine("Ok, Guest 2, you're up!\r\nWhat is your check total before tip?\r\n(Do not enter a $ with your value)");

            //Creating variable guestTwo for the user's input of their check total before tip
            string guestTwo = Console.ReadLine();

            //Guest 2 total before tip converted to decimal
            decimal guestTwoBT = decimal.Parse(guestTwo);

            Console.WriteLine("Perfect!\r\nNow, how much would you like to leave for a tip?\r\nPlease input a value between 1-100 and hit enter.\r\n(Do not enter a % with your value)");

            //Creating variable tipGuestTwo for the user's desired tip percentage
            string tipGuestTwo = Console.ReadLine();

            //Guest 2 tip percentage converted to decimal
            decimal tipGuestTwoParsed = decimal.Parse(tipGuestTwo);

            //Guest 2 total calculation
            decimal guestTwoTotal = Math.Round(((tipGuestTwoParsed / 100) * guestTwoBT) + guestTwoBT, 2);

            Console.WriteLine("Ok, Guest 3, save the best for last!\r\nWhat is your check total before tip?\r\n(Do not enter a $ with your value)");

            //Creating variable guestThree for the user's input of their check total before tip
            string guestThree = Console.ReadLine();

            //Guest 3 total before tip
            decimal guestThreeBT = decimal.Parse(guestThree);

            Console.WriteLine("Perfect!\r\nNow, how much would you like to leave for a tip?\r\nPlease input a value between 1-100 and hit enter\r\n(Do not enter a % with your value)");

            //Creating variable tipGuestThree for the user's desired tip percentage
            string tipGuestThree = Console.ReadLine();

            //Guest 3 tip percentage converted to decimal
            decimal tipGuestThreeParsed = decimal.Parse(tipGuestThree);

            //Guest 3 total calculation
            decimal guestThreeTotal = Math.Round(((tipGuestThreeParsed / 100) * guestThreeBT) + guestThreeBT, 2);

            Console.WriteLine("Got it!\r\nHere's your party's check totals:");
            Console.WriteLine("Guest 1: $" + guestOneTotal + "\r\nGuest 2: $"+guestTwoTotal+"\r\nGuest 3: $"+guestThreeTotal+"");

            //Tip amounts for each guest based on tip value entered by guest earlier
            decimal tipGuestOneDec = (tipGuestOneParsed / 100) * guestOneBT;

            decimal tipGuestTwoDec = (tipGuestTwoParsed / 100) * guestTwoBT;

            decimal tipGuestThreeDec = (tipGuestThreeParsed / 100) * guestThreeBT;

            //Tip total for waiter calculation
            decimal tipTotal = Math.Round(tipGuestOneDec + tipGuestTwoDec + tipGuestThreeDec, 2);
          
            //Grand total with tips calculation
            decimal grandTotal = Math.Round(guestOneTotal + guestTwoTotal + guestThreeTotal, 2);

            //Split check calculation
            decimal splitCheck = Math.Round(grandTotal / 3, 2);

            Console.WriteLine("Total tip for your waiter: $" + tipTotal + "\r\nGrand total: $" + grandTotal + "\r\nIf you'd like to split that 3 ways: $" + splitCheck + " each");

            /*
             * Test 1 Output:
               Here's your party's check totals:
               Guest 1: $11.50
               Guest 2: $17.25
               Guest 3: $30.00
               Total tip for your waiter: $8.75
               Grand total: $58.75
               If you'd like to split that 3 ways: $19.58 each

               Test 2 Output:
               Here's your party's check totals:
               Guest 1: $28.18
               Guest 2: $21.56
               Guest 3: $37.20
               Total tip for your waiter: $14.19
               Grand total: $86.94
               If you'd like to split that 3 ways: $28.98 each
             */





        }
    }
}
