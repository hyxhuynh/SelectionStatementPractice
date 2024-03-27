namespace SelectionStatementPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            Random r = new Random();
            int favNumber = r.Next(1, 1000); // Generates a random number between 1 and 999

            Console.WriteLine("Guess my favorite number between 1 and 1000:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed it!!!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Too low");
            }

            // EXERCISE 2
            Console.WriteLine("What is your favorite school subject? (For example: Math, Biology, Chemistry, Physics, Literature, etc.)");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Cool! Do you like Calculus or Geometry?");
                    break;
                case "literature":
                    Console.WriteLine("Nice! Do you like Shakespeare?");
                    break;
                case "biology":
                    Console.WriteLine("Awesome! Do you like botany (studies of plants), zoology (studies of animals), or microbiology (studies of microbes)?"); 
                    break;
                case "chemistry":
                    Console.WriteLine("Amazing! Do you like Organic or Inorganic chemistry?");
                    break;
                case "physics":
                    Console.WriteLine("Fun fact: Physics is also called \"the fundamental science\" because all branches of natural science like chemistry, astronomy, geology, and biology are constrained by laws of physics.");
                    break;
                default:
                    Console.WriteLine($"Interesting choice! What do you like about {favoriteSubject}?");
                    break;
            }

        }
    }
}
