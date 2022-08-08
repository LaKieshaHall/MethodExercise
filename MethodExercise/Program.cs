using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hiya! What is your name?");
            var username = Console.ReadLine();

            Console.WriteLine($"Well hello {username}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is so beautiful! What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"YEEEESSSSS! {band} is awesome, especially live! What is your favorite animal?");
            var animal = Console.ReadLine();
        }
    }
}
