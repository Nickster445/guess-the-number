using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you wish to start the game? (Y/N)");
            string yn = Console.ReadLine();

            if(yn=="Y" || yn=="y"){
                //if started this is where game logic will be:
                Random rnd = new Random();
                int number = rnd.Next(1,100);
                Console.WriteLine("Calculating the number you need to guess");
                Console.Write("[#");
                System.Threading.Thread.Sleep(1000);
                Console.Write("#");
                System.Threading.Thread.Sleep(1000);
                Console.Write("#");
                System.Threading.Thread.Sleep(1000);
                Console.Write("#]");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine(" I have now chosen a number, what's your first guess?");

                int guess = 0;
                int tries = 0;

                while(guess!=number) {
                    guess = Int32.Parse(Console.ReadLine());

                    if(guess>number){
                        Console.WriteLine("too high!");
                    } else if(guess<number){
                        Console.WriteLine("too low!");
                    } else{
                        break;
                    }
                    tries++;

                }
                if(guess==number){
                    Console.WriteLine($"Congrats you guessed the number {number} correctly, and it only took you {tries} to guess!");
                    Console.WriteLine(" ");
                    Console.WriteLine("press any key to close program..");
                    Console.ReadKey();
                }

            } else {
                Console.Write("press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
