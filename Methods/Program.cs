using Methods; // importing the Methods namespace

//Console.WriteLine(); // this is a method

//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}


string name = ConsoleMessages.GetUsersName();
ConsoleMessages.SayHi(name);

double result = MathShortcuts.Add(5, 3);
Console.WriteLine($"The results is {result}");
//or Console.WriteLine($"The results is { MathShortcuts.Add(5, 3) }"); 

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