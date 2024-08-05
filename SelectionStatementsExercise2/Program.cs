namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();
            
             

            switch(subject)
            {
                case "Math":
                    Console.WriteLine("Math is fun!");
                break;

                case "English":
                    Console.WriteLine("English is boring!");
                break;

                case "Science":
                    Console.WriteLine("Science is useful");
                break;

                case "Astronomy":
                    Console.WriteLine("astronomy is very exciting");
                break;

                case "World History":
                    Console.WriteLine("World History can be exciting to learn");
                break;





            }
        }
    }
}