using Methods; // importing the Methods namespace

//Console.WriteLine(); // this is a method

//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}


Console.Write("What is your name: ");
string name = Console.ReadLine(); // the variable here doens't need to be the same name as in the method
ConsoleMessages.SayHi(name);

MathShortcuts.Add(5, 3);

double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
MathShortcuts.AddAll(vals);

ConsoleMessages.SayGoodbye();

// or (could appear in code but not recommended to use)

//using static Methods.SampleMethods;
//SayHi();

// could also be used for Console.WriteLine();

//using static System.Console;
//WriteLine();

// DRY - Don't Repeat Yourself -> (don't repeat logic...), having a method helps you easily change the code that is called multiple times in one go
// (instead of looking for each copy of it)

// SOLID - S -> SRP -> Single Responsibility Principle -> each thing should only do one thing
// e.g. Program.cs is just calling methods (like a QB calling the play)