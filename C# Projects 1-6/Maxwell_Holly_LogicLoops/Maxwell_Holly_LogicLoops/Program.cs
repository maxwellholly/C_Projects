using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_LogicLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Holly Maxwell
             7/15/18
             Logic Loops
             Sect 01
             
             */

            //Making The Grade

            //Welcome to the program
            Console.WriteLine("Hi, welcome to Making The Grade!");
            Console.WriteLine("Please input your first test grade and hit enter");

            string test1GradeString = Console.ReadLine();
            //Verify the input is not blank
            while (string.IsNullOrWhiteSpace(test1GradeString))
            {


                Console.WriteLine("Oops, it looks like you left that blank, please input your first\r\ntest grade and hit enter");

                test1GradeString = Console.ReadLine();


            }

            int.TryParse(test1GradeString, out int test1Grade);
            //Verify the input is a valid number
            while (!(int.TryParse(test1GradeString, out test1Grade)))
            {

                Console.WriteLine("Oops, it looks like you didn't input a valid number, please input your\r\nfirst test grade and hit enter");
                test1GradeString = Console.ReadLine();
                int.TryParse(test1GradeString, out test1Grade);

            }
            //Verify the input is also a valid grade between 0 and 100
            while (test1Grade > 100 || test1Grade < 0)
            {

                Console.WriteLine("Oops, you entered a grade value outside of 0 to 100, please input a valid test grade");
                test1GradeString = Console.ReadLine();
                int.TryParse(test1GradeString, out test1Grade);

            }
            //Ask for the second grade
            Console.WriteLine("Ok, now, what is your second test grade?");

            string test2GradeString = Console.ReadLine();
            //Verify the input is not blank
            while (string.IsNullOrWhiteSpace(test2GradeString))
            {

                Console.WriteLine("Oops, it looks like you left that blank, please input your second\r\ntest grade and hit enter");

                test2GradeString = Console.ReadLine();


            }

            int.TryParse(test2GradeString, out int test2Grade);
            //Verify the input is a valid number
            while (!(int.TryParse(test2GradeString, out test2Grade)))
            {

                Console.WriteLine("Oops, it looks like you didn't enter a valid number, please input\r\nyour second test grade and hit enter");
                test2GradeString = Console.ReadLine();
                int.TryParse(test2GradeString, out test2Grade);


            }

            //Verify the input is also a valid grade between 0 and 100
            while (test2Grade > 100 || test2Grade < 0)
            {

                Console.WriteLine("Oops, you entered a grade value outside of 0 to 100, please input a valid test grade");
                test2GradeString = Console.ReadLine();
                int.TryParse(test2GradeString, out test2Grade);

            }

            int[] testGrades = new int[2] { test1Grade, test2Grade };

            if (testGrades[0] >= 70 && testGrades[1] >= 70)
            {

                Console.WriteLine("Congrats, both grades are passing!");

            }
            else
            {

                Console.WriteLine("One or more grades are failing, try harder next time!");

            }

            /*
             Tests:
Hi, welcome to Making The Grade!
Please input your first test grade and hit enter
eighty
Oops, it looks like you didn't input a valid number, please input your
first test grade and hit enter
80
Ok, now, what is your second test grade?
91
Congrats, both grades are passing!

Hi, welcome to Making The Grade!
Please input your first test grade and hit enter
1000
Oops, you entered a grade value outside of 0 to 100, please input a valid test grade
100
Ok, now, what is your second test grade?
35
One or more grades are failing, try harder next time!
             
             
             
             
             */

            //Brunch Bunch

            //Welcome to the program

            Console.WriteLine("Hello, welcome to Brunch Bunch!\r\nLet's see which brunch price you are eligible for");
            //Ask for their age
            Console.WriteLine("\r\nWhat is your age?\r\nPress enter when done");
            string userAgeString = Console.ReadLine();
            //Verify that the input is not blank
            while (string.IsNullOrWhiteSpace(userAgeString))
            {

                Console.WriteLine("Oops, it looks like you left that blank, please enter your name and hit return");
                userAgeString = Console.ReadLine();



            }
            int.TryParse(userAgeString, out int userAge);
            //Verify that the input is valid
            while (!(int.TryParse(userAgeString, out userAge)))
            {

                Console.WriteLine("Oops, it looks like you entered something other than your age,\r\nplease enter your age and hit return");


            }

            //Conditional to test which price the customer is eligible for
            if (userAge >= 55 || userAge < 10)
            {

                Console.WriteLine("Your cost for brunch today is $10.00");

            }
            else
            {

                Console.WriteLine("Your cost for brunch today is $15.00");

            }

            /*
             Test results:
1.
Hello, welcome to Brunch Bunch!
Let's see which brunch price you are eligible for

What is your age?
Press enter when done
57
Your cost for brunch today is $10.00

2.
Hello, welcome to Brunch Bunch!
Let's see which brunch price you are eligible for

What is your age?
Press enter when done
39
Your cost for brunch today is $15.00

3.
Hello, welcome to Brunch Bunch!
Let's see which brunch price you are eligible for

What is your age?
Press enter when done
8
Your cost for brunch today is $10.00

4. 
Hello, welcome to Brunch Bunch!
Let's see which brunch price you are eligible for

What is your age?
Press enter when done
10
Your cost for brunch today is $15.00

5.
Hello, welcome to Brunch Bunch!
Let's see which brunch price you are eligible for

What is your age?
Press enter when done
97
Your cost for brunch today is $10.00
             
             
             
             */


            //Add Them Up

            //Welcome to the program

            Console.WriteLine("Hello, welcome to Add Them Up!\r\nLet's see how many DVDs, Blu-Rays, and Digital UltraViolet copies you own!");

            //Prompt for user owned DVDs
            Console.WriteLine("\r\nHow many DVDs do you own?\r\nPlease enter and value and hit return");
            string dvdsString = Console.ReadLine();
            //Verify input is not blank
            while (string.IsNullOrWhiteSpace(dvdsString))
            {

                Console.WriteLine("It looks like you left that blank, please enter the number of DVDs you own\r\nand hit return");
                dvdsString = Console.ReadLine();

            }

            int.TryParse(dvdsString, out int dvds);
            //Verify the input is a number
            while (!(int.TryParse(dvdsString, out dvds)))
            {

                Console.WriteLine("It looks like you entered an invalid input, please enter the number of DVDs you own\r\nand hit return");
                dvdsString = Console.ReadLine();
                int.TryParse(dvdsString, out dvds);

            }

            //Prompt for Blu-Rays owned
            Console.WriteLine("How many Blu-Rays do you own?\r\nPlease enter a value and hit return");
            string bluRaysString = Console.ReadLine();
            //Test for blank input
            while (string.IsNullOrWhiteSpace(bluRaysString))
            {

                Console.WriteLine("It looks like you left that blank, please enter the number of Blu-Rays you own\r\nand hit return");
                bluRaysString = Console.ReadLine();


            }

            int.TryParse(bluRaysString, out int bluRays);
            //Test for invalid input
            while (!(int.TryParse(bluRaysString, out bluRays)))
            {

                Console.WriteLine("It looks like you entered an invalid input, please enter the number of Blu-Rays you own\r\nand hit return");
                bluRaysString = Console.ReadLine();
                int.TryParse(bluRaysString, out bluRays);


            }
            //Prompt for Digital UltraViolet copies
            Console.WriteLine("How many Digital UltraViolet copies do you own?\r\nPlease enter a value and hit return");

            string digitalUltraVioletsString = Console.ReadLine();

            //Test for blank input
            while (string.IsNullOrWhiteSpace(digitalUltraVioletsString))
            {

                Console.WriteLine("It looks like you left that blank, please enter the number of Digital UltraViolet\r\ncopies you own and hit return");
                digitalUltraVioletsString = Console.ReadLine();


            }

            int.TryParse(digitalUltraVioletsString, out int digitalUltraViolets);

            while (!(int.TryParse(digitalUltraVioletsString, out digitalUltraViolets)))
            {


                Console.WriteLine("It looks like you didn't enter a valid input, please enter the number\r\nof Digital Ultra Violet copies you own");
                digitalUltraVioletsString = Console.ReadLine();
                int.TryParse(digitalUltraVioletsString, out digitalUltraViolets);

            }
            //Create array to store inputs
            int[] itemsOwned = new int[3] { dvds, bluRays, digitalUltraViolets };

            int sumItemsOwned = 0;
            //Use foreach loop to add all items in itemsOwned array
            foreach (int arrayItem in itemsOwned)
            {


                sumItemsOwned = sumItemsOwned + arrayItem;




            }

            if (sumItemsOwned > 100)
            {

                Console.WriteLine("Wow, I am impressed with your collection of {0} movies!", sumItemsOwned);

            }
            else
            {

                Console.WriteLine("You have a total of {0} movies in your collection.", sumItemsOwned);

            }


            /*
             Test results:

1.
Hello, welcome to Add Them Up!
Let's see how many DVDs, Blu-Rays, and Digital UltraViolet copies you own!

How many DVDs do you own?
Please enter and value and hit return
45
How many Blu-Rays do you own?
Please enter a value and hit return
15
How many Digital UltraViolet copies do you own?
Please enter a value and hit return
2
You have a total of 62 movies in your collection.    

2.
Hello, welcome to Add Them Up!
Let's see how many DVDs, Blu-Rays, and Digital UltraViolet copies you own!

How many DVDs do you own?
Please enter and value and hit return
60
How many Blu-Rays do you own?
Please enter a value and hit return
75
How many Digital UltraViolet copies do you own?
Please enter a value and hit return
45
Wow, I am impressed with your collection of 180 movies!
       
3.
Hello, welcome to Add Them Up!
Let's see how many DVDs, Blu-Rays, and Digital UltraViolet copies you own!

How many DVDs do you own?
Please enter and value and hit return
80
How many Blu-Rays do you own?
Please enter a value and hit return
17
How many Digital UltraViolet copies do you own?
Please enter a value and hit return
88
Wow, I am impressed with your collection of 185 movies!
             
             
             
             
             
             
             */

            //Cha-Ching!

            Console.WriteLine("Hello, welcome to Cha-Ching!");
            Console.WriteLine("What is your giftcard amount?\r\nPlease enter the value and hit return");
            string giftCardAmountString = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(giftCardAmountString))
            {

                Console.WriteLine("It looks like you left that blank, please enter your giftcard amount");

            }
            decimal.TryParse(giftCardAmountString, out decimal giftCardAmount);
            while (!(decimal.TryParse(giftCardAmountString, out giftCardAmount)))
            {

                Console.WriteLine("You didn't enter a valid number, please try again");
                giftCardAmountString = Console.ReadLine();
                decimal.TryParse(giftCardAmountString, out giftCardAmount);

            }


        }
    }
}
