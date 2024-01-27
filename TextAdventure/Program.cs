using System;

namespace TextAdventure 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Print backstory to user
            Console.WriteLine("************************************");
            Console.WriteLine("  Welcome to the Haunted Mansion");
            Console.WriteLine("************************************");
            Console.WriteLine("You have just inherited a mansion from a distant relative.");
            Console.WriteLine("Now that you are the new owner, you decide to check it out.");
            Console.WriteLine("The house is dated, creepy, and falling apart. You walk in the front door.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Do you want to enter the living room or the dining room?");

            // Prompt the user for choice
            Console.Write("> ");
            string roomChoice = Console.ReadLine();

            // Choice of room
            if(roomChoice == "living room")
            {
                Console.WriteLine("You chose to go into the living room.");
                Console.WriteLine("As you walk in, you see a sleeping pitbull guarding some gold jewelry.");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Do you want to steal the jewelry?");

                // Prompt for choice
                Console.Write("> ");
                string pitBullChoice = Console.ReadLine();

                if(pitBullChoice == "yes")
                {
                    Console.WriteLine("You attempt to steal the jewelry, but the pitbull rips you to shreds.");
                    Console.WriteLine("You are DEAD!");
                }
                else if(pitBullChoice == "no")
                {
                    Console.WriteLine("You decide not to steal the dogs jewelry.");
                    Console.WriteLine("You turn back and find your way out of the house safely.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please answer yes or no.");
                }
            }
            else if(roomChoice == "dining room")
            {
                Console.WriteLine("You chose to go into the dining room.");
                Console.WriteLine("You see a shiny vase.");
                Console.WriteLine("");
                Console.WriteLine("Do you want to open it?");

                //Prompt the user for choice
                Console.Write("> ");
                string vaseChoice = Console.ReadLine();

                if(vaseChoice == "yes")
                {
                    Console.WriteLine("You open the vase and find a pile of bones.");
                }
                else if(vaseChoice == "no")
                {
                    Console.WriteLine("You decide not to open the vase.");
                    Console.WriteLine("As you turn to leave you hear a cracking sound coming from the corner.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("A dark figure with glowing red eyes launches at you, knocking you unconcious.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("You wake up in your bed.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("It was all a dream....");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("Or was it?");
                    System.Threading.Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter yes or no.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice. Please answer living room or dining room.");
            }
        }
    }
}