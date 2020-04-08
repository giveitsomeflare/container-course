using System;

namespace strings_app
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {            
                Console.WriteLine("Enter a string to check it's length or type quit to exit the app:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit") { break; }
                Console.WriteLine(input.Length);
            }
        }
    }
}
