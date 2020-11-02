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

            // data types
            char abjad = 'A';            // char
            string saying = "good luck"; // string
            int score = 95;              // integer
            double price = 8.99;         // double
            bool blood_donor = true;     // boolean
            bool late_to_work = false;   // boolean

            Console.WriteLine(abjad);
            Console.WriteLine(saying);
            Console.WriteLine(score);
            Console.WriteLine(price);
            Console.WriteLine(blood_donor);
            Console.WriteLine(late_to_work);

            // strings
            string string_text = "I am a long and elaborate string indeed";

            Console.WriteLine(string_text[0]);
            Console.WriteLine($"The length of text is {string_text.Length} bytes.");
            Console.WriteLine(string_text.Substring(7, 4));
            Console.WriteLine(string_text.Substring(7));

            // arithmetic operators
            /*
                + addition
                - subtraction
                * multiplication
                / division
                % modulo (yields the remainder)
            */

            // maths
            int first = 16;
            int second = 4;
            int result;

            result = first + second;
            Console.WriteLine(result);
            result = first - second;
            Console.WriteLine(result);
            result = first * second;
            Console.WriteLine(result);
            result = first / second;
            Console.WriteLine(result);
            result = first % second;
            Console.WriteLine(result);

            int numbers = 10;

            numbers += 100;
            Console.WriteLine(numbers);
            numbers -= 100;
            Console.WriteLine(numbers);
            numbers *= 100;
            Console.WriteLine(numbers);
            numbers /= 100;
            Console.WriteLine(numbers);
            numbers++; // increment
            Console.WriteLine(numbers);
            numbers--; // decrament
            Console.WriteLine(numbers);

            Console.WriteLine(Math.Pow(4, 2)); // power
            Console.WriteLine(Math.Sqrt(144)); // square root

            // user input
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, you was {age}");

            // arrays
            int[] primes = {2, 3, 5, 7, 11};

            Console.WriteLine(primes[0]);
            Console.WriteLine(primes[1]);
            Console.WriteLine(primes[2]);
            Console.WriteLine(primes[3]);
            Console.WriteLine(primes[4]);

            int[][] grids = {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            Console.WriteLine(grids[0][0] + " " + grids[0][1] + " " + grids[0][2]);
            Console.WriteLine(grids[1][0] + " " + grids[1][1] + " " + grids[1][2]);
            Console.WriteLine(grids[2][0] + " " + grids[2][1] + " " + grids[2][2]);
            
            // functions
            call();

            sayHello("Mike", 24);
            sayHello("Albert", 23);
            sayHello("Banning", 22);

            // returns
            volumeCube(4.0);

            Console.WriteLine(volumeCube(6.0));
            double answer = volumeParallelepiped(2.0, 3.0, 5.0);
            Console.WriteLine($"Volume of Parallelepiped is {answer}");
        }

        static void call()
        {
            Console.WriteLine("You call this function");
        }

        static void sayHello(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you was {age}");
        }
        
        static double volumeCube(double side)
        {
            double result = side * side * side;

            return result;
        }

        static double volumeParallelepiped(double length, double width, double height)
        {
            double result = length * width * height;

            return result;
        }
    }
}
