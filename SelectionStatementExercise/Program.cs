namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;
            var counter = 0;

            do
            {
                Console.WriteLine("guess a number between 1 and 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine("that guess is too high");
                }

                else if (userInput < favNumber)
                {
                    Console.WriteLine("that guess is too low");
                }

                else
                {
                    Console.WriteLine("congradulations!! you guessed correctly");
                }
                counter++;
                Console.WriteLine($"you have guessed this many times {counter}");
            }
            while (userInput != favNumber);   

        }
    }
}
