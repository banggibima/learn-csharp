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
            this.title = "Tidak ada judul";
            this.director = "Tidak ada sutradara";
            this.years = 0;
        }

        public Movie(string aTitle, string aDirector, int aYears)
        {
            this.title = aTitle;
            this.director = aDirector;
            this.years = aYears;
        }
    }
    
    class Student
    {
        public string name;
        public int age;
        public string major;
        public double gpa;

        public Student(string aName, int aAge, string aMajor, double aGpa)
        {
            this.name = aName;
            this.age = aAge;
            this.major = aMajor;
            this.gpa = aGpa;
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
                this.genre = "Tidak ada genre";
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
        public void makeNasiGoreng()
        {
            Console.WriteLine("Chef membuat nasi goreng");
        }

        public void makeAyamBakar()
        {
            Console.WriteLine("Chef membuat ayam bakar");
        }

        public void makeMenuSpesial()
        {
            Console.WriteLine("Chef membuat soto ayam");
        }
    }
    
    class JavaneseChef : Chef
    {
        public void makeRawon()
        {
            Console.WriteLine("Chef membuat rawon");
        }

        public void makePecel()
        {
            Console.WriteLine("Chef membuat pecel");
        }

        public void makeMenuSpesial()
        {
            Console.WriteLine("Chef membuat rujak cingur");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // output
            Console.WriteLine("Hello World");
            Console.Write("Selamat ");
            Console.Write("Pagi");
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
            string character_name = "Budi";
            int character_age = 17;

            Console.WriteLine($"Pernah ada seorang pria bernama {character_name}");
            Console.WriteLine($"Dia berusia {character_age} tahun");
            
            character_age = 19;
            
            Console.WriteLine($"Dia sangat suka namanya {character_name}");
            Console.WriteLine($"Tapi dia tidak suka ketika berusia {character_age}");

            // data types
            char abjad = 'A';                   // char
            string saying = "semoga berhasil";  // string
            int score = 95;                     // integer
            double price = 8.99;                // double
            bool blood_donor = true;            // boolean
            bool late_to_work = false;          // boolean

            Console.WriteLine(abjad);
            Console.WriteLine(saying);
            Console.WriteLine(score);
            Console.WriteLine(price);
            Console.WriteLine(blood_donor);
            Console.WriteLine(late_to_work);

            // string
            string string_text = "Ini memang benang yang panjang dan rumit";

            Console.WriteLine(string_text[0]);
            Console.WriteLine($"Panjang teks ini {string_text.Length} byte.");
            Console.WriteLine(string_text.Substring(7, 4));
            Console.WriteLine(string_text.Substring(7));

            // operator aritmatika
            /*
                + penjumlahan
                - pengurangan
                * perkalian
                / pembagian
                % modulus
            */

            // mathematics
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

            Console.WriteLine(Math.Pow(4, 2)); // pangkat
            Console.WriteLine(Math.Sqrt(144)); // akar pangkat

            // input
            Console.Write("Masukan namamu: ");
            string name = Console.ReadLine();
            Console.Write("Masukan usiamu: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Halo {name}, kamu berusia {age} tahun");

            // single array
            int[] primes = {2, 3, 5, 7, 11};

            Console.WriteLine(primes[0]);
            Console.WriteLine(primes[1]);
            Console.WriteLine(primes[2]);
            Console.WriteLine(primes[3]);
            Console.WriteLine(primes[4]);

            // multi array
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

            sayHello("Budi", 17);
            sayHello("Andi", 19);
            sayHello("Reni", 21);

            // returns
            volumeCube(4.0);

            Console.WriteLine(volumeCube(6.0));
            double answer = volumeParallelepiped(2.0, 3.0, 5.0);
            Console.WriteLine($"Volume dari persegi panjang ini adalah {answer}");

            // operator relasi
            /*
                == sama dengan
                != tidak sama dengan
                >  lebih dari
                <  kurang dari
                >= lebih dari sama dengan
                <= kurang dari sama dengan
            */

            // if statements
            int index = 10;

            if (index == 10)
            {
                Console.WriteLine("Benar");
            }

            // else clause
            int years = 1991;

            if (years == 1991)
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }

            // else if clause
            int apple = 7;

            if (apple > 8)
            {
                Console.WriteLine("Jumlah apel lebih dari 8");
            } 
            else if (apple < 6)
            {
                Console.WriteLine("Jumlah apel kurang dari 6");
            }
            else
            {
                Console.WriteLine("Jumlah apel sama dengan 7");
            }

            // switch statements
            int grade = 2;

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Freshman");
                    break;
                case 2:
                    Console.WriteLine("Sophomore");
                    break;
                case 3:
                    Console.WriteLine("Junior");
                    break;
                case 4:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            // operator logika
            /*
                && dan
                || atau
                ! tidak
            */

            // conditionals
            int coffee = 1;
            int donut = 2;
            bool tired;
            tired = true;

            if (coffee > 0 && donut > 1)
            {
                Console.WriteLine("Kopi saya lebih banyak dari 0 dan donat saya lebih banyak dari 1");
            }

            if (coffee > 0 || donut > 1)
            {
                Console.WriteLine("Kopi saya lebih banyak dari 0 atau donat saya lebih banyak dari 1");
            }

            if (!tired)
            {
                Console.WriteLine("Saya tidak lelah");
            }

            // while loop
            int a = 1;

            while (a <= 5)
            {
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine();

            // do while loop
            int b = 1;

            do
            {
                Console.Write(b + " ");
                b++;
            }
            while (b <= 5);
            Console.WriteLine();

            // for loop
            int c;

            for (c = 1; c <= 5; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            // break
            int d, e = 5;

            for (d = 1; d <= 10; d++)
            {
                if (d == e)
                {
                    break;
                }
                Console.Write(e + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Ketika bernilai " + e + " maka berhenti");

            // continue
            int f, g = 7;

            for (f = 1; f <= 10; f++)
            {
                if (f == g)
                {
                    continue;
                }
                Console.Write(f + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Ketika bernilai " + g + " maka nilai " + g + " akan hilang");

            // classes object
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

            // konstruktor
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

            // object function
            Student student1 = new Student("Nindy", 20, "Bisnis", 3.4);
            Student student2 = new Student("Beni", 23, "Seni", 3.8);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());

            // getters setters
            Music sundaybest = new Music("Sunday Best", "Surfaces", "Soul");

            Console.WriteLine(sundaybest.title);
            Console.WriteLine(sundaybest.artist);
            Console.WriteLine(sundaybest.setGenre());

             // inheritance
            Chef chef = new Chef();
            chef.makeNasiGoreng();
            chef.makeAyamBakar();
            chef.makeMenuSpesial();

            JavaneseChef javaneseChef = new JavaneseChef();
            javaneseChef.makeRawon();
            javaneseChef.makePecel();
            javaneseChef.makeNasiGoreng();
            javaneseChef.makeAyamBakar();
            javaneseChef.makeMenuSpesial();
        }

        static void call()
        {
            Console.WriteLine("Kamu memanggil fungsi ini");
        }

        static void sayHello(string name, int age)
        {
            Console.WriteLine($"Halo {name}, kamu berusia {age} tahun");
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
