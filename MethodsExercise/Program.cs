namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Once upon a time, there was a person named {userName}. They loved the color {color}, adored {animal}, and couldn't get enough of {band}'s music.");
            Console.WriteLine($"One day, while {userName} was out and about, they stumbled upon a magical moment. They encountered a {animal} that seemed to dance to the rhythm of {band}'s tunes. It was a sight that filled {userName} with joy.");
            Console.WriteLine($"From that day on, whenever {userName} saw their favorite color, {color}, heard their favorite band, {band}, or encountered their favorite animal, {animal}, they couldn't help but smile and remember that magical dance they witnessed.");

        }
    }
}
