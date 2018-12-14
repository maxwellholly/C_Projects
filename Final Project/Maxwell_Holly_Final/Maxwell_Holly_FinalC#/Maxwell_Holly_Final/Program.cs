using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Maxwell_Holly_Final
{
    class Program
    {
        static string outputFolder = @"..\..\Output";

        static void Main(string[] args)
        {


            //Change the background color of the console to dark green
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            //Create output folder
            Directory.CreateDirectory(outputFolder);

            //Game introduction
            Console.WriteLine("~STAGE~");
            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("Stage is a story progression game that transports you back to the simple pleasures of childhood,\r\n where life is kind of like life...just a little more interesting.\r\n\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("Simply press enter to begin your story...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome...what is your name?\r\n");

            //Store the user's name in a variable
            string name = Console.ReadLine();

            //Verify that their name is not empty and it does not contain any numbers
            while (string.IsNullOrEmpty(name) || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("0"))
            {

                Console.Clear();
                Console.WriteLine("Wow, what a unique name. I can't even pronounce it! Could you repeat that?\r\n");
                name = Console.ReadLine();

            }
            Console.Clear();

            //string array to store possible responses 
            string[] nameResponses = new string[] { $"\r\nFantastic! Welcome {name}!", $"\r\n{name}? Ok...", $"\r\n{name}...great.", $"\r\nOh I love the name {name}, welcome!", $"\r\nOh! I have an opossum named {name}!" };

            //calling on randomizing method to choose a response at randome
            Console.WriteLine(nameResponses[Randomize(nameResponses)]);

            //initialize the main character
            Character mainCharacter = new Character(name);

            Console.WriteLine(mainCharacter.Describe());

            //Saves the current main character to the output file 
            Save(mainCharacter.Describe());

            Console.WriteLine("\r\nOk, I think I've got some that are your size...\r\nAh! Here they are!\r\nAre you ready for this fully immersive experience?\r\n*HUGE goggles are placed on your head and almost instantly you begin falling asleep*");

            Console.ReadKey();

            Menus.YoungChildMenus(mainCharacter);

            Save("\r\nSTORY END");

        }
    
        
           public static int Randomize(string[] outputs)
           {
                Random randomResponse = new Random();

                int index = randomResponse.Next(outputs.Length);

                return index;

           }

        public static void Save(string toSave)
        {
            //save story data
            using (StreamWriter outStream = new StreamWriter(outputFolder + @"\StoryData.txt", true))
            {
                outStream.WriteLine(toSave);
            }

        }



    }

 
    
}
