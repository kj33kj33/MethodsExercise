namespace MethodsExercise
{
    public class Program
    {

        public static void AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("Sum: " + sum);
        }

        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            Console.WriteLine("Sum: " + answer);
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            Console.WriteLine("Difference: " + answer);
            return answer;            
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            Console.WriteLine("Product: " + answer);
            return answer;
        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            Console.WriteLine("Quotient: " + answer);
            return answer;
        }

        public static int Modulus(int num1, int num2)
        {
            var answer = num1 % num2;
            Console.WriteLine("Remainder: " + answer);
            return answer;
        }

        static void ExerciseOne()
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

        static void ExerciseTwo()
        {
            Console.WriteLine("Pick a number.");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick another number.");
            var num2 = int.Parse(Console.ReadLine());

            Add(num1, num2);

            Subtract(num1, num2);

            Multiply(num1, num2);

            Divide(num1, num2);

            Modulus(num1, num2);

            AddNumbers(1, 1, 1, 1, 1);
        }

        static void Main(string[] args)
        {
            ExerciseOne();

            ExerciseTwo();
        }
    }
}
