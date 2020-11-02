using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{   
    class Book
    {
        public string title;
        public string author;
    }

    class Movie
    {
        public string title;
        public string director;
        public int years;

        public Movie()
        {
            this.title = "no title";
            this.director = "no director";
            this.years = 0;
        }

        public Movie(string atitle, string adirector, int ayears)
        {
            this.title = atitle;
            this.director = adirector;
            this.years = ayears;
        }
    }

    class Student
    {
        public string name;
        public int age;
        public string major;
        public double gpa;

        public Student(string aname, int aage, string amajor, double agpa)
        {
            this.name = aname;
            this.age = aage;
            this.major = amajor;
            this.gpa = agpa;
        }

        public bool hasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }

     class Music
    {
        public string title;
        public string artist;

        public Music(string title, string artist, string genre)
        {
            this.title = title;
            this.artist = artist;
            this.setGenre(genre);
        }

        public void setGenre(string genre)
        {
            if (genre == "Pop" || genre == "Jazz" || genre == "Blues" || genre == "Metal" || genre == "Rock")
            {
                this.genre = genre;
            }
            else
            {
                this.genre = "No Genre";
            }
        }

        public string setGenre()
        {
            return genre;
        }

        private string genre;
    }

    class Chef
    {
        public void makeChicken()
        {
            Console.WriteLine("The chef makes yummy chicken");
        }

        public void makeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public void makeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }

    class ItalianChef : Chef
    {
        public void makePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
        public void makeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }

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

            // logical operators
            /*
                && requires both to be true (and)
                || requires either to be true (or)
                ! negates the result (not)
            */

            // conditionals
            int coffee = 1;
            int donut = 2;
            bool tired;
            tired = true;

            if (coffee > 0 && donut > 1)
            {
                Console.WriteLine("My coffee greater than 0 and my donut greater than 1");
            }

            if (coffee > 0 || donut > 1)
            {
                Console.WriteLine("My coffee greater than 0 or my donut greater than 1");
            }

            if (!tired)
            {
                Console.WriteLine("I am not tired");
            }

            // while loop
            Console.Write("Create your PIN numbers: ");
            int new_pin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your PIN numbers: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            while (pin != new_pin)
            {
                Console.WriteLine("Try again!");
                Console.Write("Enter your PIN numbers: ");
                pin = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Yes you right");

            // do while loop
            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a <= 5);

            // for loop
            int b;

            for (b = 0; b < 10; b++)
            {
                Console.WriteLine(b);
            }

            // classes objects
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J. K. Rowling";

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);

            // constructor
            Movie movie1 = new Movie("Parasite", "Bong Joon Ho", 2019);
            Movie movie2 = new Movie("Contagion", "Steven Soderbergh", 2011);

            Console.WriteLine(movie1.title);
            Console.WriteLine(movie1.director);
            Console.WriteLine(movie1.years);

            Console.WriteLine(movie2.title);
            Console.WriteLine(movie2.director);
            Console.WriteLine(movie2.years);

            Movie movie3 = new Movie();

            Console.WriteLine(movie3.title);
            Console.WriteLine(movie3.director);
            Console.WriteLine(movie3.years);

            // object functions
            Student student1 = new Student("Jimmy", 21, "Business", 3.4);
            Student student2 = new Student("Packie", 20, "Art", 3.8);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());

            // getters setters
            Music sundaybest = new Music("Sunday Best", "Surfaces", "Soul");

            Console.WriteLine(sundaybest.title);
            Console.WriteLine(sundaybest.artist);
            Console.WriteLine(sundaybest.setGenre());

             // inheritance
            Chef chef = new Chef();
            chef.makeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.makePasta();
            italianChef.makeSpecialDish();
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
