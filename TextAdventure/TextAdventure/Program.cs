/*
 * Egg Hunt
 * Joe Fabre, November 2020
 * <<Uses of the cod was approved with credit given.  The code did help my knowledge development.>> 
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;

namespace Adventure
{
    public static class Game
    {
        static int Scenarios = 3;
        static string CharacterName;

        static string[] PartOne = {
            "At the front of the swank building you see a tired old man with a buggy.\nAs you near, you see the buggy is filled with what looks like mostly junk and \nonly a few useful items. All you have on you is piece of a candy.\nYou offer it to him, and he says he'll trade a flashlight or an umbrella for it.\nTo choose type either A for the flashlight, or B for the umbrella.",
            "The power in the building goes out - luckily you have a flashlight! \nYou move the light around and a large animal is frightened by the \nsudden brightness and takes off. As you move the light again, \nsomething glitters. You reach down and pick up a coin!",
            "The power in the building goes out! As you move down the hallway \nyou hear what sounds like a large animal nearby. You move the \numbrella in a widening arc in front of you to scare it, \nand the animal skitters off.",
            "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
            "Luckily " + CharacterName + " you have that coin you found and you buy yourself a snack.",
            "Too bad you don't have a coin on you," + CharacterName + "\nor you would have been able to get a snack.",
            "You begin to climb the stairs to the next floor."
        };
        static string[] PartTwo = {
            "At the top of the steps of the second floor of the building you see a trashcan.\nAs you near, you see an empty gum wrapper in the trashcan and other common trash items.\nOnly the gum wrapper seems useful. All you can focus on is that metalic gum wrapper.\nYou hesitate to dig in the trashcan to retrieve it, and say to your self, To take or not to take?.\nTo choose type either A to take the wrapper, or B to not take the wrapper.",
            "You place the wrapper in your pocket and stroll down a dimly lit hallway - you chuckle to yoursefl and think how you just dug into a trashcan for a gum wrapper. \nYou find yourself in front of a locked glass door at the end of the hallway, which has an old wired alarm system. \nYou can faintly see inside of the room beyond the glass door.\nYou notice something glittering on the floor - it is a key marked OFFICE. You reach down and pick up the key!",
            "You place your hands in your pocket and stroll down a dimly lit hallway. As you move down the hallway - you can't believe you actually thought about digging in a trash can. \nYou find yourself in front of a locked glass door at the end of the hallway, which has an old wired alarm system. \nYou can faintly see inside of the room beyond the glass door. \nYou notice something glittering on the floor - it is a key marked OFFFICE.  Your reach down and bick up the key!",
            "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
            "Luckily " + CharacterName + " you have that coin you found and you buy yourself a snack.",
            "Too bad you don't have a coin on you," + CharacterName + "\nor you would have been able to get a snack.",
            "You begin to climb the stairs to the next floor."
        };
        static string[] PartThree = {
            "Description of story part three... and the choice A or B",
            "... part 3 - what happens if A is chosen...",
            "... part 3 - what happens if B is chosen...",
            "....more story.... .",
            "... part 3, again - what happens if A is chosen...",
            "... part 3 again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };

        public static void StartGame()
        {
            GameTitle();

            //introduction text
            Console.WriteLine("You are about to enter the headquarters of your arch nemesis.");

            NameCharacter();
            Choice();
            EndGame();
        }

        public static void EndGame()
        {

            //end of game text
            Console.WriteLine("End of story text here.....");
            Console.WriteLine("Congratulations " + CharacterName + "!");


        }
        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        //Part One

                        //same pattern for each of the sections. 1) print the first part of the section
                        Console.WriteLine(PartOne[0]);

                        //2)read in player's choice (a or b)
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        //3) if a print the next part of the array, otherwise skip next and print 3rd
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        //4) print next part of the section
                        Console.WriteLine(PartOne[3]);

                        //5) again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[5]);
                        }

                        //6) print last piece of the section
                        Console.WriteLine(PartOne[6]);



                        break;

                    case 2:
                        //Part Two

                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                        }
                        Console.WriteLine(PartTwo[3]);
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                        }
                        Console.WriteLine(PartTwo[6]);

                        break;

                    case 3:
                        //Part Three
                        Console.WriteLine(PartThree[0]);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }
                        Console.WriteLine(PartThree[3]);
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[5]);
                        }
                        Console.WriteLine(PartThree[6]);
                        break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }

                //let player advance when ready, then clear the screen
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
        static void NameCharacter()
        {
            Console.WriteLine("You need a code name for this mission. What will it be?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter your code name: ");

            CharacterName = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("Your code name is confirmed to be " + CharacterName + ". Good luck!\n\n");

        }

        static void GameTitle()
        {
            string Title = @"A or B!";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Red;
            //game title
            Console.WriteLine(Title);
            //game slogan/subtitle
            Console.WriteLine("An Awesome Beginner Adventure Game");
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }
    }
    class Item
    {

    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
            //Does not need to be part of the program, but a fun exit.
            Typewrite("That's all folks!");
            Console.ReadKey();
        }
        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                System.Threading.Thread.Sleep(300);
            }
        }

    }
}