using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Final
{
    class Menus
    {
        public static void YoungChildMenus(Character mainCharacter)
        {
            Console.Clear();
            //Initial decision presented
            //Lable used to return to this point in the code if an invalid input is stored           
            tryAgain: Console.WriteLine("\r\n" +
                 "You wake up, cozy and snug, in your bed. \r\nAfter rubbing your eyes you notice 3 toys placed neatly beside you...a plush monkey, some blocks and a fire engine." +
                 "\r\nWhich toy will you choose?");

            //Variable to capture the user's choice
            string choice = Console.ReadLine().ToLower();

            //Switch statement based on the user's choice
            switch (choice)
            {
                //All story progressions have been designed with scalability in mind, so that more storyline/choices/characteristics can be added later
                case "monkey":
                case "plush monkey":
                case "plush":
                    {
                        Console.Clear();

                        Program.Save($"{mainCharacter.Name} has chosen the plush monkey.");

                        Animal dad = new Animal("human", "dad");
                        Console.WriteLine("While playing with your new monkey friend you hear footsteps approaching the door to your room.\r\nYour door opens and in walks your dad with your coat and boots.\r\n'It's time to head to the park!' he exclaims.\r\n");

                        Console.WriteLine("He helps you get bundled and the two of you head off.\r\n");

                        Console.WriteLine("Once at the park, you see all of your favorite places to play...the swings, the see-saw, and of course the open field...\r\n");

                        //Lable used to return to this point in the code if an invalid input is stored
                        tryAgain2: Console.WriteLine("Which part of the park do you want to play in?");
                        string response = Console.ReadLine().ToLower();

                        switch (response)
                        {
                            case "swings":
                            case "swing":
                            case "swinging":
                            case "go swinging":
                            case "go swing":
                                {
                                    Console.Clear();

                                    Program.Save($"{mainCharacter.Name} has chosen to swing.");

                                    Console.WriteLine("You sit comfortably on the swing waiting for your dad to push you.\r\n");
                                    Console.WriteLine("He pushes you until you're soaring high, grinning ear to ear." +
                                        "\r\nBut with this last push, something peculiar happens...you soar high but you don't come back down!" +
                                        "\r\nYou're just floating...FLYING!" +
                                        "\r\nYour dad looks on in amazement and a little bit of uneasy fear.\r\n" +
                                        $"'{mainCharacter.Name} can you get down?!'\r\n" +
                                        $"You come down, but instead of landing you grap your dad by the shoulders and fly him all the way home.");

                                    Program.Save($"{mainCharacter.Name} can fly!");

                                    Console.WriteLine("\r\nTHE END");

                                    Console.ReadKey();

                                }
                                break;
                            case "see-saw":
                            case "see saw":
                            case "seesaw":
                                {
                                    Console.Clear();

                                    Program.Save($"{mainCharacter.Name} has chosen to play on the see-saw.");

                                    Console.WriteLine("Once the two of you push off of the ground, you feel a splash of water and begin looking around to notice\r\n that you're no longer in the park!\r\n" +
                                        "The see-saw has turned into a pirate ship and you and your dad are now in the middle of a giant bathtub...\r\n" +
                                        "The two of you begin to laugh and play, digging through treasure and exploring.\r\n" +
                                        "You spend hours playing pirates, until he says 'We should probably head home now,' \r\nand just like that you're back home in a warm bath getting ready for dinner and a nap.\r\n");

                                    Program.Save($"{mainCharacter.Name} is playing on a pirate ship!");

                                    Console.WriteLine("\r\nTHE END");

                                    Console.ReadKey();
                                }
                                break;
                            case "field":
                            case "open field":
                                {
                                    Console.Clear();

                                    Program.Save($"{mainCharacter.Name} has chosen to play in the open field.");

                                    Animal rabbit = new Animal("rabbit", "black rabbit");
                                    Console.WriteLine("As you roll and laugh in the grass you see a black bunny rabbit hopping towards you.\r\n" +
                                        "You stay as still as possible so that you don't scare it away but the rabbit just stops and stares at you puzzled\r\n" +
                                        "then says 'why are you playing statue? Is there danger around?' You stare back even more puzzled.\r\n" +
                                        "The small black rabbit moves in closer and says 'My name is Nari, what's yours?'\r\n" +
                                        $"'{mainCharacter.Name}' you say.\r\n" +
                                        $"'Well hello {mainCharacter.Name}, I think we're going to be good friends...I'll see you next time you come to play'\r\n he said before disappearing into the nearby bushes.\r\n" +
                                        $"Your dad comes, picks you up and says 'we better head home'.\r\n");

                                    rabbit.Name = "Nari";

                                    Program.Save($"{mainCharacter.Name} met a talking rabbit named {rabbit.Name}!");

                                    Console.WriteLine("\r\nTHE END");

                                    Console.ReadKey();
                                }
                                break;
                            default:
                                Console.WriteLine("\r\nThat doesn't exist here, pick one of the areas to play in this park.\r\n");

                                //goto calls on the appropriate label to return to
                                goto tryAgain2;
                        }


                    }
                    break;
                case "blocks":
                case "some blocks":
                    {
                        Console.Clear();

                        Program.Save($"{mainCharacter.Name} has chosen the blocks.");

                        Animal bosco = new Animal("dog", "Bosco");
                        Console.WriteLine("While building your tower to the moon you hear clattering, growing louder and louder.\r\n");
                        Console.WriteLine($"Finally, your dog, {bosco.Name}, bursts into the room and exclaims 'HURRY, WE MUST GO!' before putting\r\nyou on his back and racing off.\r\n");
                        Console.WriteLine("'You can talk?!' you exclaim. 'Yes!' Bosco barks 'Now, there's an emergency we must attend to! Quick!'\r\n" +
                            "Bosco runs directly for the kitchen, he runs so excidedly that he slides halfway accross the tiled\r\nfloor before stopping.\r\n" +
                            "'Where's the emergency?' you ask.\r\n" +
                            "'Can't you see it?! My dog food bag is COMPLETELY EMPTY!' he responds.\r\n" +
                            $"'I need you to feed me from the refridgerator...' {bosco.Name} trails off.\r\n" +
                            $"So, you open the refidgerator for {bosco.Name} and have a delicious feast.\r\n\r\n");

                        Program.Save($"{mainCharacter.Name}'s dog {bosco.Name} can talk!");

                        Console.WriteLine("THE END");

                        Console.ReadKey();

                    }
                    break;
                case "fire engine":
                case "engine":
                    {
                        Console.Clear();

                        Program.Save($"{mainCharacter.Name} has chosen the fire engine.");

                        Animal mom = new Animal("human", "mom");

                        Console.WriteLine("You hear footsteps drawing closer to your room until the door opens and a bear wearing\r\nyour mom's clothes looks in on you.\r\n" +
                            "'Are you ready for your playdate?' she asks.\r\n" +
                            "'Yes' you reply without hesitation, you love playdates!\r\n" +
                            "'Alright, get your shoes on we're leaving now' she says sweetly.\r\n" +
                            "You put your shoes on and head to your playdate.\r\n");

                        mom.Species = "bear";

                        Program.Save($"{mainCharacter.Name}'s mom is a bear!");

                        Animal leo = new Animal("lion", "Leo");
                        Animal barry = new Animal("bear", "Barry");
                        Animal arnold = new Animal("ostrich", "Arnie");
                        Animal claire = new Animal("zebra", "Claire");

                        Animal[] animals = new Animal[] { leo, barry, arnold, claire };

                        Console.WriteLine("When you get there, there aren't any children!\r\n" +
                            "There are only animals, and when they see you arrive they all start towards you.\r\n");

                        //Array loop iteration
                        for (int i = 0; i < animals.Length; i++)
                        {
                            Console.WriteLine(animals[i].Describe());
                        }

                        Console.WriteLine($"You smile and say 'I'm {mainCharacter.Name}' and you all play safari for what seems like hours!\r\n");


                        Console.WriteLine("THE END");

                        Console.ReadKey();


                    }
                    break;
                case "":
                case " ":
                    {
                        Console.WriteLine("Hmmm, I don't see one of those lying around...let's try that again.");
                        //goto calls on the appropriate label to return to
                        goto tryAgain;
                    }
            }

        }

    }
}
