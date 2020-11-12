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
            "With great curiosity you wonder is this key to this office. \nYour stomach fills with excitment, you proceed to enter the room.",
            "Luckily " + CharacterName + " you have that wrapper you found to bypass the wired alarm system just like Eddie Murphy did in Beverly Hills Cop.",
            "Too bad you don't have that wrapper on you," + CharacterName + "\nas soon as you unlocked the door you set of the alarm which is now blasting loudly.",
            "You assess your next move - make it a good one - you say to yourself."
        };
        static string[] PartThree = {
            "Inside of the office you realize you are one step closer to solving the puzzle.\nYou look around, and notice the office is filled with old metal desks.\nYou hesitate for a moment, but begin to rifle through the desks.  When all of a sudden you hear footsteps.  You think of hiding under a desk or running out the door.\nTo choose type either A to hide, or B to run.",
            "You duck under a desk in the nick of time as the night watchman strolls in to the open office. He shines his light back and forth scanning the room, and takes a seat at the desk in front of the one you are hiding under. \nThe guard pulls out a cellphone and dials a number; he begins to have a long conversation with his signifigant other.\nYou patiently wait for the conversation to end, and the guard leaves the office, locking behind him.",
            "You run out of the office in a panic. BAM! You run right into the arms of the night watchman. He begins to question you, asking who you are and why are you in the building this late. He stares at you sternly with great curiosity. \nYou curse yourself - why didn't I just hide? The guard grows impatient, and reaches for his radio - base this is - HEY STOP! HAULT - you run past hime down the flight of stairs and out of the building into the night...",
            "With some relief you sigh then inhale deeply.",
            "Luckily " + CharacterName + " you hid under the desk as you were able to gain vaulable informaiton from the guard. You found out the exact location of the safe containing the hiddend treasures - personel files.",
            "Too bad you ran," + CharacterName + "\nas soon as you thought the coast was clear a beat cop grabbed you and took you into custody for questioning.",
            //"You assess your next move - make it a good one - you say to yourself."
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