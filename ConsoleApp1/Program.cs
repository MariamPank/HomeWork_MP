using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task #1

            Console.Write("Your Favourite Movie: ");
            string movieName = Console.ReadLine();

            Console.Write("Director's First and Last Name: ");
            string director = Console.ReadLine();
            Console.Write("Release Year: ");
            Int32 releaseYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Brief Description: ");
            string description = Console.ReadLine();
            Console.Write("Budget: USD ");
            Int32 budget = Convert.ToInt32(Console.ReadLine());
            Console.Write("IMDB Rating: ");
            double rating = Convert.ToDouble(Console.ReadLine());

            Console.Write("Golden Globe [Y/N]: ");
            char goldenGlobe = char.Parse(Console.ReadLine());
            
            Console.Write("Oscar Winner [True/False]: ");
            bool oscar = bool.Parse(Console.ReadLine());


            if ( goldenGlobe == 'Y' && oscar)
            {
                Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}. This movie won the Golden Globe and the Oscar");
            }
            else if(oscar)
            {
                Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}. This movie won the Oscar");
            }
            else if (goldenGlobe == 'Y')
            {
                Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}. This movie won the Golden Globe");
            }
            else
            {
                Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}");
            }


            //Task #2
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Personal ID: ");
            string personalId = Console.ReadLine();
            Console.Write("Age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Height: ");
            Int32 height = Int32.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            Int32 weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Married [True/False]: ");
            Boolean married = Boolean.Parse(Console.ReadLine());
            Console.Write("Pets [True/False]: ");
            Boolean pets = Boolean.Parse(Console.ReadLine());

            if(married && pets)
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg. I am married and I have pets.");
            }
            else if (married)
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg. I am married.");
            }
            else if (pets)
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg. I have pets.");
            }
            else
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg.");

            }
    }
    }
}
