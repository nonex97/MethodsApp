using System;


namespace Methods
{
	public static class ConsoleMessages // can be public (anyone can use), internal (anyone inside this project), private (anyone inside of this scope)
	{
		public static void SayHi()
		{
            Console.WriteLine("Hello User!");
            Console.WriteLine("I hope you're having a good day!");
		}
	}
}

// or (ONLY .NET 6.0 and after), there can be only one namespace anyway and you lose one set of curly braces

//namespace Methods
//public static class SampleMethods
//{

//}