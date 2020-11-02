using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // output
            Console.WriteLine("Hello World");
            Console.Write("Good");
            Console.Write("Morning");
            Console.Write("!");
            Console.WriteLine();

            // drawing a shape
            Console.WriteLine("1          ");
            Console.WriteLine("1 2        ");
            Console.WriteLine("1 2 3      ");
            Console.WriteLine("1 2 3 4    ");
            Console.WriteLine("1 2 3 4 5  ");
            Console.WriteLine("1 2 3 4 5 6");

            // variables
            string character_name = "Banggi";
            int character_age = 17;

            Console.WriteLine($"There once was a man named {character_name}");
            Console.WriteLine($"He was {character_age} years old");
            
            character_age = 19;
            
            Console.WriteLine($"He really like the name {character_name}");
            Console.WriteLine($"But didn't like being {character_age}");
        }
    }
}
