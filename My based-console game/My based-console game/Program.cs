using System;
using System.Collections.Generic;
using System.Timers;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace My_based_console_game
{
    internal class Program
    {
        private static Timer newTimer;
        private static bool TrueUntilTimeRunsOut = true;
        static async void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();
            string[] FriendOrEnemy = { "friend", "enemy" };

            

            int RandomFriendOrEnemy;
            string ThePlayerAction;
            /*
                        Console.WriteLine("Be careful! Do not flashlight on the friends");

                        while (TrueUntilTimeRunsOut)
                        {

                            RandomFriendOrEnemy = rand.Next(0, 2);

                            Console.WriteLine();
                            newTimer = new Timer(2000);
                            newTimer.Elapsed += (sender, e) => Console.WriteLine(FriendOrEnemy[RandomFriendOrEnemy] + " What's you going to do?\nF-\tFor using the Flashligh\nG-\tFor giving a gift");
                            newTimer.AutoReset = false;
                            newTimer.Enabled = true;


                            ThePlayerAction = Console.ReadLine().ToLower();

                            if (RandomFriendOrEnemy == 0 && ThePlayerAction == "g")
                            {
                                Console.WriteLine();
                                Console.WriteLine("The 'friend' is now happy :)");
                                Console.WriteLine();
                            }
                            else if (RandomFriendOrEnemy == 0 && ThePlayerAction == "f") {
                                Console.WriteLine();
                                Console.WriteLine("The 'friend' is now unhappy :(");
                                Console.WriteLine();
                            }
                            else if (RandomFriendOrEnemy == 1 && ThePlayerAction == "f") 
                            {
                                    Console.WriteLine();
                                    Console.WriteLine("The 'enemy' is now away");
                            } else if (RandomFriendOrEnemy == 1 && ThePlayerAction == "g") {
                                Console.WriteLine();
                                Console.WriteLine("The 'enemy' got you");
                                Console.WriteLine();
                                Console.WriteLine("You lost the game :(");

                                TrueUntilTimeRunsOut = false;
                            }



                        }*/


            Console.WriteLine("Enter Something");
            Console.Write("Your Answer: ");

            ThePlayerAction = await ReadLineWithTimeoutAsync(1000);


            Console.ReadLine();

        }

        static async Task<string> ReadLineWithTimeoutAsync(int Timeout)
        {
            Task<string> task = task.RunSynchronously()
        }

       public static string JumpScareThePlayer(string thePlayerAction)
        {
            if (thePlayerAction == "")
            {
                return "You should have entered something :(";
            }
            else {
                return thePlayerAction;
            }
        }

    }
}
