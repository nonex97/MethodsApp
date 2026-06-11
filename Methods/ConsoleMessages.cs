using System;


namespace Methods
{
    public static class ConsoleMessages // can be public (anyone can use), internal (anyone inside this project), private (anyone inside of this scope)
    {
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hello {firstName}!");
            Console.WriteLine("I hope you're having a good day.");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye, my user.");
            Console.WriteLine("Thank you for visiting.");
            Console.WriteLine("I cannot wait to see you again.");
        }

        public static string GetUsersName() // string instead of void since we want to return a value 
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }

        // Tuple - allows you to return two or more parameters
        public static (string firstName, string lastName) GetFullName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }
    }
}

// or (ONLY .NET 6.0 and after), there can be only one namespace anyway and you lose one set of curly braces

//namespace Methods
//public static class SampleMethods
//{

//}