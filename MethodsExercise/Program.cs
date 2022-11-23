namespace MethodsExercise
{
    public class Program
    {
        // Exercise 1 Creating User Profile

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine(); //input

            Console.WriteLine($"{name} What is your favorite color?");

            string favoriteColor = Console.ReadLine(); //input

            Console.WriteLine($"{favoriteColor} Is also my favorite color. What is your favorite animal?");

            string favoriteAnimal = Console.ReadLine(); //input

            Console.WriteLine($"I'm a cat person myself. What is your favorite band?");

            string favoriteBand = Console.ReadLine(); //input

            Console.WriteLine($"{favoriteBand}, That's cool I'm also a fan. Where were you born?");

            string bornIn = Console.ReadLine(); //input

            Console.WriteLine($"{bornIn}? My sister lives there currently. Where do you live now?");

            string liveIn = Console.ReadLine(); //input

            Console.WriteLine($"{name}, thanks for your input. Here is your profile.");

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Name: {name}");

            Console.WriteLine($"Favorite Color: {favoriteColor}");

            Console.WriteLine($"Favorite Animal: {favoriteAnimal}");

            Console.WriteLine($"Favorite Band: {favoriteBand}");

            Console.WriteLine($"Born: {bornIn}");

            Console.WriteLine($"Reside: {liveIn}");

            // Exercise 2 Calling Methods

            Methods.Add(5, 10, 10);
            Methods.Subtract(10, 10);
            Methods.Multiply(10, 20);
            Methods.Divide(200, 2);
            Methods.Modulus(100, 9);
        }
    }
}
