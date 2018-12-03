using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Holly Maxwell
             7/15/18
             Conditionals
             Sect 01          
             */


            //Baking Converter
            Console.WriteLine("Hello, Welcome to Baking Converter!\r\nWhere we convert between grams and ounces for you!\r\n");
            //Prompt user for weight value
            Console.WriteLine("Please enter the weight you would like to convert and press return");
            //Store value in variable
            string userInputWeight = Console.ReadLine();
            //Verify the user's input is not blank
            while (string.IsNullOrWhiteSpace(userInputWeight)) {


                Console.WriteLine("Oops! It looks like you left that blank, please enter a weight and press return");

                userInputWeight = Console.ReadLine();

            }
            //Create variable to store user input after conversion
            double weight;
            double.TryParse(userInputWeight, out weight);

            //Verify the user's input is a number
            while (!(double.TryParse(userInputWeight, out weight)))
            {

                Console.WriteLine("Oops! It looks like you entered something other than a number,\r\nplease enter a weight and press return");

                userInputWeight = Console.ReadLine();

                double.TryParse(userInputWeight, out weight);

            }

            

            

            //Ask the user for input units oz or g
            Console.WriteLine("Perfect, is that in oz or g? (Please input oz or g and press enter)");
            //Store the input in a variable
            string userUnit = Console.ReadLine();
            //Verify the user's input isn't blank
            while (string.IsNullOrWhiteSpace(userUnit)) {

                Console.WriteLine("Oops, it looks like you left that blank, please enter either oz or g and press return");

                userUnit = Console.ReadLine();

            }

           //Use if loop to calculate the conversion based on the user's inputs
            if (userUnit == "oz")
            {
                double gWeight = weight * 28.34952;


                Console.WriteLine("The weight is {0} grams", Math.Round(gWeight, 3));

            } else if (userUnit == "OZ")
            {
                double gWeight = weight * 28.34952;


                Console.WriteLine("The weight is {0} grams", Math.Round(gWeight, 3));
            } else if (userUnit == "g")
            {

                double ozWeight = weight / 28.34952;
                

                Console.WriteLine("The weight is {0} ounces", Math.Round(ozWeight, 5));

            } else if (userUnit == "G")
            {
                double ozWeight = weight / 28.34952;


                Console.WriteLine("The weight is {0} ounces", Math.Round(ozWeight, 5));
            } else
            {

                Console.WriteLine("It looks like you entered a unit that is not supported by this program\r\nPlease restart");

            }

            /*
             Output of test values:
             1.
             Hello, Welcome to Baking Converter!
             Where we convert between grams and ounces for you!

             Please enter the weight you would like to convert and press return
             200
             Perfect, is that in oz or g? (Please input oz or g and press enter)
             g
             The weight is 7.05479 ounces
             2.
             Hello, Welcome to Baking Converter!
             Where we convert between grams and ounces for you!

             Please enter the weight you would like to convert and press return
             12
             Perfect, is that in oz or g? (Please input oz or g and press enter)
             oz
             The weight is 340.194 grams
             3.
             Hello, Welcome to Baking Converter!
             Where we convert between grams and ounces for you!

             Please enter the weight you would like to convert and press return
             50
             Perfect, is that in oz or g? (Please input oz or g and press enter)
             OZ
             The weight is 1417.476 grams

             4.
             Hello, Welcome to Baking Converter!
             Where we convert between grams and ounces for you!

             Please enter the weight you would like to convert and press return
             400
             Perfect, is that in oz or g? (Please input oz or g and press enter)
             G
             The weight is 14.10959 ounces                         
            
             */

            //Pizza Per Person

            //Welcome to the program
            Console.WriteLine("Hello, welcome to Pizza Per Person!\r\nLet's see if you have enough pizza.");
            //Prompt user for number of pizzas
            Console.WriteLine("How many pizzas did you order?");
            string pizzaNumString = Console.ReadLine();


            //Verify the user's input is not blank
            while (string.IsNullOrWhiteSpace(pizzaNumString))
            {

                Console.WriteLine("Oops! It looks like you left that blank, how many pizzas did you order?");
                pizzaNumString = Console.ReadLine();


            }



            //Verify the user's input is valid
            int pizzaNum;
            int.TryParse(pizzaNumString, out pizzaNum);
            while (!(int.TryParse(pizzaNumString, out pizzaNum))) {

                Console.WriteLine("Oops, it looks like you entered something other than a number,\r\nplease enter the number of pizzas you ordered and hit return");
                pizzaNumString = Console.ReadLine();
                int.TryParse(pizzaNumString, out pizzaNum);

            }

            //Ask for the amount of slices per pizza

            Console.WriteLine("Ok, how many slices are there per pizza?\r\nEnter a number and hit return");

            string sliceNumString = Console.ReadLine();
            //Is the user input blank?
            while (string.IsNullOrWhiteSpace(sliceNumString))
            {
                Console.WriteLine("Oops! It looks like you left that blank, how many slices are there per pizza?\r\nEnter and number and hit return");

                sliceNumString = Console.ReadLine();

            }

            int.TryParse(sliceNumString, out int sliceNum);
            //Is the user input a number?
            while (!(int.TryParse(sliceNumString, out sliceNum)))
            {

                Console.WriteLine("Oops! It looks like you didn't enter a valid number, how many slices are there per pizza?\r\nEnter a number and hit return");
                sliceNumString = Console.ReadLine();
                int.TryParse(sliceNumString, out sliceNum);

            }

            //Prompt the user for number of party guests
            Console.WriteLine("Perfect, how many guests will be at the party?\r\nEnter a number and hit return");

            string guestNumString = Console.ReadLine();
            //Verify the input is not blank
            while (string.IsNullOrEmpty(guestNumString))
            {

                Console.WriteLine("Oops! It looks like you left that blank, how many guests will be at the party?\r\nEnter a number and hit return");
                guestNumString = Console.ReadLine();

            }

            int.TryParse(guestNumString, out int guestNum);

            //Verify that the user input is a number
            while (!(int.TryParse(guestNumString, out guestNum)))
            {

                Console.WriteLine("Oops! It looks like you didn't enter a valid number, how many guests will be at the party?\r\nEnter and number and hit return");
                guestNumString = Console.ReadLine();
                int.TryParse(guestNumString, out guestNum);

            }
            //Prompt the user for the number of slices per guest
            Console.WriteLine("Finally, how many slices will each guest eat?\r\nEnter a number and hit return");

            string slicesPerGuestString = Console.ReadLine();

            //Verify they have not left it blank

            while (string.IsNullOrEmpty(slicesPerGuestString))
            {

                Console.WriteLine("Oops! It looks like you left that blank, how many slices will each guest eat?\r\nEnter a number and hit return");
                slicesPerGuestString = Console.ReadLine();


            }

            int.TryParse(slicesPerGuestString, out int slicesPerGuest);

            //Verify that the input is a number
            while (!(int.TryParse(slicesPerGuestString, out slicesPerGuest)))
            {

                Console.WriteLine("Oops! It looks like you didn't enter a valid number, how many slices will each guest eat?\r\nEnter a number and hit return");
                slicesPerGuestString = Console.ReadLine();
                int.TryParse(slicesPerGuestString, out slicesPerGuest);

            }

            int totalNumSlices = pizzaNum * sliceNum;
            int slicesNeeded = slicesPerGuest * guestNum;
            int leftOvers = totalNumSlices - slicesNeeded;
            int moreSlices = slicesNeeded - totalNumSlices;


            if (totalNumSlices >= slicesNeeded)
            {
                Console.WriteLine("Yes, you have enough pizza for your guests with {0} slices left over.", leftOvers);

            }
            else
            {

                Console.WriteLine("You need at least {0} more slices of pizza. You should order more pizza.", moreSlices);

            }

            /*
             
            Test results:
            1.
            Hello, welcome to Pizza Per Person!
            Let's see if you have enough pizza.
            How many pizzas did you order?
            10
            Ok, how many slices are there per pizza?
            Enter a number and hit return
            8
            Perfect, how many guests will be at the party?
            Enter a number and hit return
            11
            Finally, how many slices will each guest eat?
            Enter a number and hit return
            5
            Yes, you have enough pizza for your guests with 25 slices left over.
            2.
            Hello, welcome to Pizza Per Person!
            Let's see if you have enough pizza.
            How many pizzas did you order?
            5
            Ok, how many slices are there per pizza?
            Enter a number and hit return
            6
            Perfect, how many guests will be at the party?
            Enter a number and hit return
            8
            Finally, how many slices will each guest eat?
            Enter a number and hit return
            5
            You need at least 10 more slices of pizza. You should order more pizza.
            3.
            Hello, welcome to Pizza Per Person!
            Let's see if you have enough pizza.
            How many pizzas did you order?
            20
            Ok, how many slices are there per pizza?
            Enter a number and hit return
            4
            Perfect, how many guests will be at the party?
            Enter a number and hit return
            10
            Finally, how many slices will each guest eat?
            Enter a number and hit return
            2
            Yes, you have enough pizza for your guests with 60 slices left over.

                      
             
             
            */

            //Tax Brackets
            //Welcome to program
            Console.WriteLine("Hello, welcome to Tax Brackets\r\nLet's find out which tax bracket you are in.");
            //Prompt for user income
            Console.WriteLine("What is your yearly income? Press enter when done");
            string userIncomeString = Console.ReadLine();
            //Verity input is not blank
            while (string.IsNullOrWhiteSpace(userIncomeString))
            {

                Console.WriteLine("Oops! It looks like you left that blank, please enter your yearly income and hit return");
                userIncomeString = Console.ReadLine();

            }

            decimal.TryParse(userIncomeString, out decimal userIncome);
            //Verify input is a valid number
            while (!(decimal.TryParse(userIncomeString, out userIncome)))
            {

                Console.WriteLine("Oops! It looks like you didn't enter a valid number\r\nEnter your income and hit return");
                userIncomeString = Console.ReadLine();
                decimal.TryParse(userIncomeString, out userIncome);

            }
            //Run input through these if statements to see which is true
            if (userIncome <= 9000)
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 1 and your tax rate is 10%.", Math.Round (userIncome, 0));

            }
            else if (userIncome < 37950 && userIncome > 9000)
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 2 and your tax rate is 15%.", Math.Round(userIncome, 0));

            }
            else if (userIncome < 91900 && userIncome >= 37950)
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 3 and your tax rate is 25%.", Math.Round(userIncome, 0));


            }
            else if (userIncome < 191650 && userIncome >= 91900)
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 4 and your tax rate is 25%.", Math.Round(userIncome, 0));

            } else if (userIncome < 416700 && userIncome >= 191650)
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 5 and your tax rate is 33%.", Math.Round(userIncome, 0));

            } else if (userIncome < 418400 && userIncome >= 416700)
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 6 and your tax rate is 35%.", Math.Round(userIncome, 0));

            } else
            {

                Console.WriteLine("You have an income of ${0} which puts you in tier 7 and your tax rate is 39.6%.", Math.Round(userIncome, 0));
            
            }

            /*
             Test results:
1.
Hello, welcome to Tax Brackets
Let's find out which tax bracket you are in.
What is your yearly income? Press enter when done
63234
You have an income of $63234 which puts you in tier 3 and your tax rate is 25%.
2.
Hello, welcome to Tax Brackets
Let's find out which tax bracket you are in.
What is your yearly income? Press enter when done
200000
You have an income of $200000 which puts you in tier 5 and your tax rate is 33%.
3.
Hello, welcome to Tax Brackets
Let's find out which tax bracket you are in.
What is your yearly income? Press enter when done
500000
You have an income of $500000 which puts you in tier 7 and your tax rate is 39.6%.
4.
Hello, welcome to Tax Brackets
Let's find out which tax bracket you are in.
What is your yearly income? Press enter when done
8960
You have an income of $8960 which puts you in tier 1 and your tax rate is 10%.

             
                      
             */

            //Discount Double Check

            //Welcome to the program
            Console.WriteLine("Welcome to Discount Double Check\r\nLet's check to see if you are getting a discount!");
            Console.WriteLine("What is the cost of your first item?\r\nHit return when finished");
            string item1CostString = Console.ReadLine();
            //Verify input is not blank
            while (string.IsNullOrWhiteSpace(item1CostString))
            {

                Console.WriteLine("Oops, you can't leave that blank!\r\nPlease enter the cost of your first item and hit return");
                item1CostString = Console.ReadLine();

            }

            decimal.TryParse(item1CostString, out decimal item1Cost);

            while (!(decimal.TryParse(item1CostString, out item1Cost)))
            {

                Console.WriteLine("Oops, it looks like you didn't enter a valid number!\r\nPlease enter the cost of your first item and hit return");
                item1CostString = Console.ReadLine();
                decimal.TryParse(item1CostString, out item1Cost);

            }
            //Ask for the second item's cost
            Console.WriteLine("Great, what is the cost of your second item?");
            string item2CostString = Console.ReadLine();
            //Verify the input is not blank
            while (string.IsNullOrWhiteSpace(item2CostString))
            {

                Console.WriteLine("Oops, it looks like you left that blank!\r\nPlease enter the cost of your second item and hit return");
                item2CostString = Console.ReadLine();

            }

            decimal.TryParse(item2CostString, out decimal item2Cost);

            while (!(decimal.TryParse(item2CostString, out item2Cost)))
            {

                Console.WriteLine("Oops, it looks like you didn't enter a valid number!\r\nPlease enter the cost of your second item and hit return");
                item2CostString = Console.ReadLine();
                decimal.TryParse(item2CostString, out item2Cost);

            }
          //Define variables for math used in if statements
            decimal totalPurchase = Math.Round(item1Cost + item2Cost, 2);
            decimal discount5 = Math.Round(totalPurchase - (totalPurchase * .05m),2);
            decimal discount10 = Math.Round(totalPurchase - (totalPurchase * .10m), 2);
            //Use if statements to categorize input
            if (totalPurchase < 50)
            {

                Console.WriteLine("Your total purchase is ${0}.", totalPurchase);
            }else if (totalPurchase > 50 && totalPurchase < 100){

                Console.WriteLine("Your total purchase is ${0}, which includes your 5% discount.", discount5);

            } else
            {

                Console.WriteLine("Your total purchase is ${0}, which includes your 10% discount.", discount10);

            }

            /*
         
            Test Results:
1.      
Welcome to Discount Double Check
Let's check to see if you are getting a discount!
What is the cost of your first item?
Hit return when finished
45.50
Great, what is the cost of your second item?
75.00
Your total purchase is $108.45, which includes your 10% discount.
2.
Welcome to Discount Double Check
Let's check to see if you are getting a discount!
What is the cost of your first item?
Hit return when finished
30.00
Great, what is the cost of your second item?
25.00
Your total purchase is $52.25, which includes your 5% discount.
3.
Welcome to Discount Double Check
Let's check to see if you are getting a discount!
What is the cost of your first item?
Hit return when finished
5.75
Great, what is the cost of your second item?
12.50
Your total purchase is $18.25.
4.
Welcome to Discount Double Check
Let's check to see if you are getting a discount!
What is the cost of your first item?
Hit return when finished
7.25
Great, what is the cost of your second item?
83.00
Your total purchase is $85.74, which includes your 5% discount.
             
             
             
             */









        }
    }
}
