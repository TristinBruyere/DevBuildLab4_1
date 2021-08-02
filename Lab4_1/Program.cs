using System;

namespace Lab4_1
{
    class Parallelogram
    {
        public double Length;
        public double Width;

        public void Resize(double newL, double newW)
        {
            if (newL < 0)
            {
                return;
            }
            else if (newW < 0)
            {
                return;
            }
            Length = newL;
            Width = newW;
        }
        public double GetArea()
        {
            return Length * Width;
        }
        public double GetPerimeter()
        {
            return Length * 2 + Width * 2;
        }
        public void Print()
        {
            Console.WriteLine("Here is your parallelogram.");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}\n");
        }
    }

    class Book
    {
        public string AuthorFirst;
        public string AuthorLast;
        public string ID;
        public string PubName;
        public int CopiesSold;

        public void Sell(int unitsSold)
        {
            if (unitsSold < 1)
            {
                return;
            }
            CopiesSold += unitsSold;
        }
        public void Print()
        {
            Console.WriteLine("Here is the info about your book.");
            Console.WriteLine($"Author's name: {AuthorFirst} {AuthorLast}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Publisher's name: {PubName}");
            Console.WriteLine($"Copies sold: {CopiesSold}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Parallelogram Class
            // First Parallelogram
            Parallelogram p1 = new Parallelogram();
            p1.Length = 10;
            p1.Width = 10;
            p1.Print();
            // Resizing Parallelogram
            Console.WriteLine("After resizing.");
            p1.Resize(20, 20);
            p1.Print();

            // Second Parallelogram
            Parallelogram p2 = new Parallelogram() { Length = 100, Width = 100 };
            Console.WriteLine("Second parallelogram.");
            p2.Print();

            // Updating Second Parallelogram
            Console.Write("Enter \"y\" to update the second parallelogram or press enter to finish: ");
            string updateParallelChoice = Console.ReadLine().ToLower();
            if (updateParallelChoice == "y")
            {
                Console.Write("New length: ");
                double newLength = double.Parse(Console.ReadLine());
                Console.Write("New width:");
                double newWidth = double.Parse(Console.ReadLine());
                p2.Resize(newLength, newWidth);
                p2.Print();
            }
            Console.Write("\nPress enter when you are ready to move on to the book class.");
            Console.ReadLine();

            // Book Class
            // First Book
            Book b0 = new Book();
            b0.AuthorFirst = "Tom";
            b0.AuthorFirst = "Dunn";
            b0.ID = "123456789";
            b0.PubName = "The Epicenter of Knowledge";
            b0.CopiesSold = 5000;
            b0.Print();
            Console.WriteLine("After selling copies of the book");
            b0.Sell(1000);
            b0.Print();
            
            // Second Book
            Book b1 = new Book() { AuthorFirst = "Tristin", AuthorLast = "Bruyere", ID = "32902390", PubName = "DevBuild", CopiesSold = 1 };
            b1.Print();
            Console.WriteLine("After selling copies of the book.");
            b1.Sell(10);
            b1.Print();
            
            // Third Book
            Book b2 = new Book() { AuthorFirst = "Simon", AuthorLast = "Fitzgerald", ID = "32498709", PubName = "The Phoenix", CopiesSold = 1000 };
            b2.Print();
            Console.WriteLine("After selling copies of the book");
            b2.Sell(1111);
            b2.Print();

            // Updating the third book
            Console.Write("Enter \"y\" to update this book or press enter to continue: ");
            string updateBookChoice = Console.ReadLine().ToLower();
            if (updateBookChoice == "y")
            {
                Console.Write("\nNew first name for b2: ");
                string newFirst = Console.ReadLine();
                b2.AuthorFirst = newFirst;
                Console.Write("New last name for b2: ");
                string newLast = Console.ReadLine();
                b2.AuthorLast = newLast;
                Console.Write("What is the ID of the book: ");
                string newID = Console.ReadLine();
                b2.ID = newID;
                Console.Write("What is the name of the publisher: ");
                string newPubName = Console.ReadLine();
                b2.PubName = newPubName;
                Console.Write("How many copies have been sold?: ");
                int newCopiesSold = Int32.Parse(Console.ReadLine());
                b2.CopiesSold = newCopiesSold;
                b2.Print();
            }

            // Option to sell copies of the third book
            Console.Write("\nEnter \"y\" to sell more copies or press enter to continue: ");
            string sellChoice = Console.ReadLine().ToLower();
            if (sellChoice == "y")
            {
                Console.Write("Units sold: ");
                int moreSold = Int32.Parse(Console.ReadLine());
                b2.Sell(moreSold);
                b2.Print();
            }
            Console.WriteLine("\nDone!");
        }
    }
}
