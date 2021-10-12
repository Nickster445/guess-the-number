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
                Console.WriteLine("works");
            } else {
                Console.Write("press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
