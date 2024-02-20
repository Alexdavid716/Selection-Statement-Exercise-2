namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "english":
                    Console.WriteLine("English is an interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I havent taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}