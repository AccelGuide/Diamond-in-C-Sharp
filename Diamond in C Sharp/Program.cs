using System;

namespace Diamond_in_C_Sharp
{
    class Program
    {
        static void Main()
        {
            int l = 10; // Size of the diamond
            for (int i = 0; i <= l; i++)
            {
                for (int j = 0; j < l - i; j++)
                {
                    Console.Write(" "); // Printing spaces before the stars
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*"); // Printing stars for the upper half of the diamond
                }
                Console.WriteLine(); // Newline after each row
            }
            for (int i = l - 1; i >= 0; i--)
            {
                for (int j = 0; j < l - i; j++)
                {
                    Console.Write(" "); // Printing spaces before the stars
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*"); // Printing stars for the lower half of the diamond
                }
                Console.WriteLine(); // Newline after each row
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadKey(); // Waits for a key press to close the console window
        }
    }
}
