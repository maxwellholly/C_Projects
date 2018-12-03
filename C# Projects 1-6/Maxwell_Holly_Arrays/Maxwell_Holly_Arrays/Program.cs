using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Holly Maxwell
              Sect 201807 01
              07/01/18
              SDI Assignment: Arrays
            */

            /* 
              -Use the 2 arrays below
              -Do Not Re-Declare or Re-Define the elements inside of it.
              -Find the total sum of each individual array  
              -Store each sum in a variable and output that variable to console
              
              -Find the average value of each individual array
              -Store each average in a variable and output that variable to console
            */


            //This is the Declare and Definition of the 2 Starting Number Arrays
            int[] firstArray = new int[4] { 7, 24, 30, 12 };
            double[] secondArray = new double[4] { 9, 20.5, 35.9, 237.24 };

            //The math below will calculate the total sum of firstArray and store it in the variable totalSumFirstArray
            int totalSumFirstArray = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];

            Console.WriteLine("The total sum of firstArray is: " + totalSumFirstArray);

            //The math below will calculate the total sum of secondArray and store it in the variable totalSumSecondArray
            double totalSumSecondArray = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];

            Console.WriteLine("The total sum of secondArray is: " + totalSumSecondArray);

            //For an accurate average of the firstArray, I'm going to convert the sum to a double
            double totalSumFirstArrayDouble = Convert.ToDouble(totalSumFirstArray);

            //The math below will calculate the average of firstArray
            double firstArrayAverage = totalSumFirstArrayDouble / 4;

            Console.WriteLine("The average of firstArray is: " + firstArrayAverage);

            //The math below will calculate the average of secondArray
            double secondArrayAverage = totalSumSecondArray / 4;

            Console.WriteLine("The average of secondArray is: " + secondArrayAverage);




            /*
               Create a 3rd number array.  
               The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your new array at the index#0 spot.
                    -This would make the first element of this array = 16
                -Repeat this for each index #.
                -Do not add them by hand, the computer must add them.
                -Do not use the numbers themselves, use the array elements.
                -After you have the completed new array, output this to the Console.
             */

            //Your code for the 3rd Array goes here


            //Creating thirdArray using addition of indexes from firstArray and secondArray
            double[] thirdArray = new double[4];
            thirdArray[0] = firstArray[0] + secondArray[0];
            thirdArray[1] = firstArray[1] + secondArray[1];
            thirdArray[2] = firstArray[2] + secondArray[2];
            thirdArray[3] = firstArray[3] + secondArray[3];

            //Writing the thirdArray to the console using concatenation
            Console.WriteLine("The thirdArray contains: "+thirdArray[0]+", "+thirdArray[1]+", "+thirdArray[2]+", "+thirdArray[3]);



            /*
               Given the array of strings below named MixedUp.  
               You must create a string variable that puts the items in the correct order to make a complete sentence 
               that is a famous phrase by Bill Gates.
                -Use each element in the array, do not re-write the strings themselves.
                - Do Not Re-Declare or Re-Define the elements inside of it.
                -Concatenate them in the correct order to form a sentence.
                -Store this new sentence string inside of a string variable you create.
                -Output this new string variable to the console.
             */

            //Declare and Define The String Array
            string[] MixedUp = new string[] { " is like measuring ", "Measuring programming progress", "aircraft building progress ", " by lines of code", "by weight." };

            string gatesQuote = MixedUp[1] + MixedUp[3] + MixedUp[0] + MixedUp[2] + MixedUp[4];

            Console.WriteLine("The Bill Gates quote should read:\r\n"+gatesQuote);


        }
    }
}
