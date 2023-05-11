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
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;            
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }

        public static int Modulus(int num1, int num2)
        {
            var answer = num1 % num2;
            return answer;
        }

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

            int answer1 = Add(33, 50);
            int answer2 = Subtract(100, 33);
            int answer3 = Multiply(3, 10);
            int answer4 = Divide(15, 3);
            int answer5 = Modulus(14, 3);

            Console.WriteLine("Sum: " + answer1);
            Console.WriteLine("Difference: " + answer2);
            Console.WriteLine("Product: " + answer3);
            Console.WriteLine("Quotient: " + answer4);
            Console.WriteLine("Remainder: " + answer5);

            AddNumbers(1, 1, 1, 1, 1);

        }
    }
}
