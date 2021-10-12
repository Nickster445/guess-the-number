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


                //this is the logic behind choosing and defining a random number
                Random rnd = new Random();
                int number = rnd.Next(1,101);

                //logic behind the 'calculating' of a random number
                //'System.Threading.Thread.Sleep(1000);' makes program wait 1000 miliseconds
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

                //defines integers for guess and tries, setting them to the defualt of 0
                int guess = 0;
                int tries = 0;

                //while loop starts after the random number has been chosen
                while(guess!=number) {
                    guess = Int32.Parse(Console.ReadLine());

                    //if the number guessed is too high it writes the line of 'too high!' 
                    if(guess>number){
                        Console.WriteLine("too high!");
                    } 
                    //if the number guessed is too high it writes the line of 'too low!'
                    else if(guess<number){
                        Console.WriteLine("too low!");
                    } 
                    //if the number is guessed it breaks out of the while loop
                    else{
                        break;
                    }
                    tries++;

                //handles logic for when number is guessed correctly
                }
                if(guess==number){
                    Console.WriteLine($"Congrats you guessed the number {number} correctly, and it only took you {tries} to guess!");
                    Console.WriteLine(" ");
                    Console.WriteLine("press any key to close program..");
                    Console.ReadKey();
                }

            } 
            //if you don't want the program to be started it exits at keystroke
            else {
                Console.Write("press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
