using System;
using System.ComponentModel.Design;
namespace NumReadLinetesthaha_extended1
{
    class Program
    {
        static void Main(string[] args)
        {
            string redoyn;
            do
            {
                //Safety text when copying -- Do not chnage the line of code of this program//
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string correctpassword = "41472";
                Console.WriteLine("Write the password:     (Hint - 144x144x2)");
                string password = Console.ReadLine();
                if (password == correctpassword)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine("Write a number please: (not zero)");
                    int tal1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Good! Now write a second number: (not zero)");
                    int tal2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Thank you! Now you will see the sums of the numbers. (+)");
                    Console.WriteLine(tal1 + tal2);

                    Console.WriteLine("And now the substractions! (-)");
                    Console.WriteLine(tal1 - tal2);

                    Console.WriteLine("Then the multiplication! (*)");
                    Console.WriteLine(tal2 * tal1);

                    Console.WriteLine("And finally the division! (/)");
                    Console.WriteLine(tal1 / tal2);

                    Console.WriteLine("Cool, now lets do your name! First type your first name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Aight, noted. Now write your surname:");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Yay, so your name is " + name + " " + surname + " am I right?");
                    string yepno = Console.ReadLine();
                    if (yepno == "yes" || yepno == "ye" || yepno == "yep" || yepno == "yeah" || yepno == "yup" || yepno == "yuh" || yepno == "ja" || yepno == "of course" || yepno == "absolutely" || yepno == "Yes" || yepno == "Ye" || yepno == "Yeah" || yepno == "Yep" || yepno == "agreed" || yepno == "indeed")
                    {

                        Console.WriteLine("Okay, great! Now let me get your city name:");
                        string city = Console.ReadLine();
                        Console.WriteLine("Now, I just want to know where do you want to go? Name a location anywhere:");
                        string resa = Console.ReadLine();

                        Console.WriteLine("Then I want the current year: ");
                        int yearnow = int.Parse(Console.ReadLine());
                        Console.WriteLine("Great, now I want your year of birth: ");
                        int birthyear = int.Parse(Console.ReadLine());

                        Console.WriteLine("Okay, thanks for the info. Now, with your agreement, I will summarize everything. Type \"agree\" to agree!");

                        string agree = Console.ReadLine();
                        if (agree == "agree")
                        {
                            Console.WriteLine("Okay, so your name is " + name + " " + surname + " and you live in " + city + " and you want to go to " + resa + "! +You're " + (yearnow - birthyear) + " years old. Am I right?");

                            string yes1 = Console.ReadLine();
                            if (yes1 == "yes" || yes1 == "ye" || yes1 == "yep" || yes1 == "yeah" || yes1 == "yup" || yes1 == "yuh" || yes1 == "ja" || yes1 == "of course" || yes1 == "absolutely" || yes1 == "Yes" || yes1 == "Ye" || yes1 == "Yeah" || yes1 == "Yep" || yes1 == "agreed" || yes1 == "indeed")
                            {
                                Console.WriteLine("Yippie!!");
                                Console.WriteLine("Now type any of these following shapes: square, rectangle, triangle, hexagon");
                                string shape = Console.ReadLine();
                                if (shape == "square")
                                {
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("|                    |");
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Here you go, does it look like a " + shape + "?");
                                    string maybeshape = Console.ReadLine();
                                    if (maybeshape == "yes" || maybeshape == "ye" || maybeshape == "yep" || maybeshape == "yeah" || maybeshape == "yup" || maybeshape == "yuh" || maybeshape == "ja" || maybeshape == "of course" || maybeshape == "absolutely" || maybeshape == "Yes" || maybeshape == "Ye" || maybeshape == "Yeah" || maybeshape == "Yep" || maybeshape == "agreed" || maybeshape == "indeed")
                                    {
                                        Console.WriteLine("Nice, I am very happy that I did a good job!");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Aww, I'm bad at this. Shapes isn't my thing I guess...");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                }
                                else if (shape == "rectangle")
                                {
                                    Console.WriteLine("----------------------------------------");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("|                                      |");
                                    Console.WriteLine("----------------------------------------");
                                    Console.WriteLine("Here you go, does it look like a " + shape + "?");
                                    string maybeshape = Console.ReadLine();
                                    if (maybeshape == "yes" || maybeshape == "ye" || maybeshape == "yep" || maybeshape == "yeah" || maybeshape == "yup" || maybeshape == "yuh" || maybeshape == "ja" || maybeshape == "of course" || maybeshape == "absolutely" || maybeshape == "Yes" || maybeshape == "Ye" || maybeshape == "Yeah" || maybeshape == "Yep" || maybeshape == "agreed" || maybeshape == "indeed")
                                    {
                                        Console.WriteLine("Nice, I am very happy that I did a good job!");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Aww, I'm bad at this. Shapes isn't my thing I guess...");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                }
                                else if (shape == "triangle")
                                {
                                    Console.WriteLine("       /\\");
                                    Console.WriteLine("      /  \\");
                                    Console.WriteLine("     /    \\");
                                    Console.WriteLine("    /      \\");
                                    Console.WriteLine("   /        \\");
                                    Console.WriteLine("  /          \\");
                                    Console.WriteLine(" /            \\");
                                    Console.WriteLine("---------------");
                                    Console.WriteLine("Here you go, does it look like a " + shape + "?");
                                    string maybeshape = Console.ReadLine();
                                    if (maybeshape == "yes" || maybeshape == "ye" || maybeshape == "yep" || maybeshape == "yeah" || maybeshape == "yup" || maybeshape == "yuh" || maybeshape == "ja" || maybeshape == "of course" || maybeshape == "absolutely" || maybeshape == "Yes" || maybeshape == "Ye" || maybeshape == "Yeah" || maybeshape == "Yep" || maybeshape == "agreed" || maybeshape == "indeed")
                                    {
                                        int prevsum = tal1 + tal2;
                                        Console.WriteLine("Nice, I am very happy that I did a good job!");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("Now, do you remember the sums of your fisrt numbers?");
                                        Console.WriteLine("If not, too bad, you'll get to know in a second!");
                                        Console.WriteLine("Anyways, now write a new number, whatever you want:");
                                        int newnum = int.Parse(Console.ReadLine());

                                        if (newnum < prevsum)
                                        {
                                            Console.WriteLine("Alright, " + newnum + " is smaller than the previous sums!");
                                            Console.WriteLine("Oh yeah, the previous sums were " + prevsum + " btw.");
                                            Console.WriteLine("Thanks for using this program! (:");
                                            Console.WriteLine("Now double-press Enter to quit.");
                                        }
                                        else if (newnum > prevsum)
                                        {
                                            Console.WriteLine("Alright, " + newnum + " is bigger than the previous sums!");
                                            Console.WriteLine("Oh yeah, the previous sums were " + prevsum + " btw.");
                                            Console.WriteLine("Thanks for using this program! (:");
                                            Console.WriteLine("Now double-press Enter to quit.");
                                        }
                                        else if (newnum == prevsum)
                                        {
                                            Console.WriteLine("Alright, " + newnum + " is the exact same as the previous sums!");
                                            Console.WriteLine("Which obviously means that the previous sums were " + prevsum + ".");
                                            Console.WriteLine("Thanks for using this program! (:");
                                            Console.WriteLine("Now double-press Enter to quit.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("How the actual fuck did you get here. Damn, good job bro you found something the programmer thought was impossible.");
                                            Console.WriteLine("You're not even getting a thanks. BYE");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Aww, I'm bad at this. Shapes isn't my thing I guess...");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }

                                }
                                else if (shape == "hexagon")
                                {
                                    Console.WriteLine("   ---------");
                                    Console.WriteLine("  /         \\");
                                    Console.WriteLine(" /           \\");
                                    Console.WriteLine("/             \\");
                                    Console.WriteLine("\\             /");
                                    Console.WriteLine(" \\           /");
                                    Console.WriteLine("  \\         /");
                                    Console.WriteLine("   ---------");
                                    Console.WriteLine("Here you go, does it look like a " + shape + "?");
                                    string maybeshape = Console.ReadLine();
                                    if (maybeshape == "yes" || maybeshape == "ye" || maybeshape == "yep" || maybeshape == "yeah" || maybeshape == "yup" || maybeshape == "yuh" || maybeshape == "ja" || maybeshape == "of course" || maybeshape == "absolutely" || maybeshape == "Yes" || maybeshape == "Ye" || maybeshape == "Yeah" || maybeshape == "Yep" || maybeshape == "agreed" || maybeshape == "indeed")
                                    {
                                        Console.WriteLine("Nice, I am very happy that I did a good job!");
                                        Console.WriteLine("Well let's do a little quiz, sha'll we. There will be 10 general knowledge quiestions.");
                                        Console.WriteLine("Answer using the numbers 1, 2 or 3. At the end you will get to know how many you got right! (Not which ones, I'm too lazy for that lol)");
                                        Console.WriteLine("This quiz is a work in progress, check back when it is done!");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Aww, I'm bad at this. Shapes isn't my thing I guess...");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                }
                                else if (shape == "minecraft")
                                {
                                    Console.WriteLine("   -----");
                                    Console.WriteLine("   |   |");
                                    Console.WriteLine("   -----");
                                    Console.WriteLine("-----------");
                                    Console.WriteLine("|  |   |  |");
                                    Console.WriteLine("|  |   |  |");
                                    Console.WriteLine("|  |   |  |");
                                    Console.WriteLine("---| | |---  ");
                                    Console.WriteLine("   | | |  ");
                                    Console.WriteLine("   | | |  ");
                                    Console.WriteLine("   -----");
                                    Console.WriteLine("Here you go, does it look like a minecraft Steve?");
                                    string maybeshape = Console.ReadLine();
                                    if (maybeshape == "yes" || maybeshape == "ye" || maybeshape == "yep" || maybeshape == "yeah" || maybeshape == "yup" || maybeshape == "yuh" || maybeshape == "ja" || maybeshape == "of course" || maybeshape == "absolutely" || maybeshape == "Yes" || maybeshape == "Ye" || maybeshape == "Yeah" || maybeshape == "Yep" || maybeshape == "agreed" || maybeshape == "indeed")
                                    {
                                        Console.WriteLine("Nice, I am very happy that I did a good job!");
                                        Console.WriteLine("Do you like the game Minecraft?");
                                        string mcyesorno = Console.ReadLine();
                                        if (mcyesorno == "no")
                                        {
                                            Console.WriteLine("Oh, okay. Then I suppose you don't care about doing a Minecraft-quiz.");
                                            Console.WriteLine("Thanks for using this program! (:");
                                            Console.WriteLine("Now double-press Enter to quit.");
                                        }
                                        else if (mcyesorno == "yes" || mcyesorno == "ye" || mcyesorno == "yep" || mcyesorno == "yeah" || mcyesorno == "yup" || mcyesorno == "yuh" || mcyesorno == "ja" || mcyesorno == "of course" || mcyesorno == "absolutely" || mcyesorno == "Yes" || mcyesorno == "Ye" || mcyesorno == "Yeah" || mcyesorno == "Yep" || mcyesorno == "agreed" || mcyesorno == "indeed")
                                        {
                                            Console.WriteLine("Nice, do you know a lot about Minecraft?");
                                            string knowmcyesno = Console.ReadLine();
                                            if (knowmcyesno == "no")
                                            {
                                                Console.WriteLine("Okay, then a quiz probably isn't for you!");
                                                Console.WriteLine("Thanks for using this program! (:");
                                                Console.WriteLine("Now double-press Enter to quit.");
                                            }
                                            else if (knowmcyesno == "yes" || knowmcyesno == "ye" || knowmcyesno == "yep" || knowmcyesno == "yeah" || knowmcyesno == "yup" || knowmcyesno == "yuh" || knowmcyesno == "ja" || knowmcyesno == "of course" || knowmcyesno == "absolutely" || knowmcyesno == "Yes" || knowmcyesno == "Ye" || knowmcyesno == "Yeah" || knowmcyesno == "Yep" || knowmcyesno == "agreed" || knowmcyesno == "indeed")
                                            {
                                                Console.WriteLine("Cool, let's do a little quiz! (If you don't want to type \"nope\", if you do just press Enter!)");
                                                string nope = Console.ReadLine();
                                                if (nope == "nope")
                                                {
                                                    Console.WriteLine("Okay, I get it...");
                                                    Console.WriteLine("Thanks for using this program! (:");
                                                    Console.WriteLine("Now double-press Enter to quit.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Great! Answer the questions with 1, 2 or 3. If you get one wrong the program ends!");
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("First question: What mob was created after Notch failed a pig?");
                                                    Console.WriteLine("1: Cow");
                                                    Console.WriteLine("2: Creeper");
                                                    Console.WriteLine("3: Ghast");
                                                    string q1 = Console.ReadLine();
                                                    if (q1 == "2")
                                                    {
                                                        Console.WriteLine("Correct!");
                                                        Console.WriteLine("Question 2: What do you use for Piglin trading?");
                                                        Console.WriteLine("1: Gold");
                                                        Console.WriteLine("2: Iron");
                                                        Console.WriteLine("3: Bread");
                                                        string q2 = Console.ReadLine();
                                                        if (q2 == "1")
                                                        {
                                                            Console.WriteLine("Correct!");
                                                            Console.WriteLine("Question 3: In what biomes can you find villages?");
                                                            Console.WriteLine("1: Desert, Plains, Jungle");
                                                            Console.WriteLine("2: Plains, Savannah, Ocean, Mountains");
                                                            Console.WriteLine("3: Savannah, Plains, Desert, Snow,");
                                                            string q3 = Console.ReadLine();
                                                            if (q3 == "3")
                                                            {
                                                                Console.WriteLine("Correct!");
                                                                Console.WriteLine("You got everything correct! Congrats!");
                                                                Console.WriteLine("Thanks for using this program! (:");
                                                                Console.WriteLine("Now double-press Enter to quit.");

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Wrong! Try again lol xD");
                                                                Console.WriteLine("Thanks for using this program! (:");
                                                                Console.WriteLine("Now double-press Enter to quit.");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Wrong! Try again lol xD");
                                                            Console.WriteLine("Thanks for using this program! (:");
                                                            Console.WriteLine("Now double-press Enter to quit.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Wrong! Try again lol xD");
                                                        Console.WriteLine("Thanks for using this program! (:");
                                                        Console.WriteLine("Now double-press Enter to quit.");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Okay, then a quiz probably isn't for you!");
                                                Console.WriteLine("Thanks for using this program! (:");
                                                Console.WriteLine("Now double-press Enter to quit.");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Oh, okay. Then I suppose you don't care about doing a Minecraft-quiz.");
                                            Console.WriteLine("Thanks for using this program! (:");
                                            Console.WriteLine("Now double-press Enter to quit.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Aww, I'm bad at this. Shapes isn't my thing I guess...");
                                        Console.WriteLine("Thanks for using this program! (:");
                                        Console.WriteLine("Now double-press Enter to quit.");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("That is not a valid shape. Or you didn't write it correctly.");
                                    Console.WriteLine("Thanks for using this program! (:");
                                    Console.WriteLine("Now double-press Enter to quit.");
                                }

                            }
                            else if (yes1 == "no")
                            {
                                Console.WriteLine("Aww, I'm bad at this ):");
                                Console.WriteLine("Thanks for using this program! (:");
                                Console.WriteLine("Now double-press Enter to quit.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid, type yes or no!");
                                Console.WriteLine("Thanks for using this program! (:");
                                Console.WriteLine("Now double-press Enter to quit.");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Since you didn't agree the program ends here! Thanks!");
                            Console.WriteLine("Thanks for using this program! (:");
                            Console.WriteLine("Now double-press Enter to quit.");
                        }
                        Console.ReadKey();
                    }
                    else if (yepno == "no")
                    {
                        Console.WriteLine("Aww, I'm bad at this ):");
                        Console.WriteLine("Thanks for using this program! (:");
                        Console.WriteLine("Now double-press Enter to quit.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid, type yes or no!");
                        Console.WriteLine("Thanks for using this program! (:");
                        Console.WriteLine("Now double-press Enter to quit.");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, that was the wrong password!");
                    Console.WriteLine("You unfortunately couldn't get acces to this program. If this was a mistake, please try again!");
                    Console.WriteLine("Double-press Enter to quit.");
                }
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Did you do something wrong, do you want to close the program or redo it? \"c\" = close, \"r\" = redo. ");
                redoyn = Console.ReadLine();
            }
            while (redoyn == "r" || redoyn == "R");
            //Safety text when copying//
        }
    }
}