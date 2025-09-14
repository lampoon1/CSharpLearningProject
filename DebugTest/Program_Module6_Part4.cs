///////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
//2025/9/6; 2025/9/8; 2025/9/13 reviewing again
//Module 6:  4 - create and throw exceptions in C# Console Applications
//Total 7 units
////////////////////////////////////////////////////////////////////////////////
//Learning objectives
//1. Learn how exception objects are created and how to customize their property settings.
//2. Develop C# console applications that create and throw customized exception objects.
//3. Develop C# console applications that catch custom exception objects and manage exception property information.
//////////////////////////////////////////////////
//Notes
//Some considerations to keep in mind when throwing an exception include:
//
//The Message property should explain the reason for the exception. 
//However, information that's sensitive, or that represents a security concern shouldn't be put in the message text.
//The StackTrace property is often used to track the origin of the exception. 
//This string property contains the name of the methods on the current call stack, 
//together with the file name and line number in each method that's associated with the exception. 
//A StackTrace object is created automatically by the common language runtime (CLR) 
//from the point of the throw statement. Exceptions must be thrown from the point where the stack trace should begin.
//
//when to throw an exception?
//whenever they can't complete their intended purpose
//based on the most specific exception available that fits the error conditions.
////////////////////////////////////////
/// Unit 2 - Examine how to create and throw exceptions in c#
/*
This scenario below:
The business process is dependent on user input. 
If the input doesn't match the expected data type, 
the method that implements the business process creates and throws an exception. 
*/

/*
using System;
using System.Net.Cache;
using System.Reflection.PortableExecutable;
using System.Xml;

namespace DebugTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //unit 2 code: example
            /*
            string[][] userEnteredValues = new string[][]
            {
                new string[] { "1", "two", "3"},
                new string[] { "0", "1", "2"}
            };

            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
                    if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            */

            //unit 2 code; try next example:
            /*
            try
            {
                OperatingProcedure1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting application.");
            }

            static void OperatingProcedure1()
            {
                string[][] userEnteredValues = new string[][]
                {
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
                };

                foreach(string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        BusinessProcess1(userEntries);
                    }
                    catch (Exception ex)
                    {
                        if (ex.StackTrace.Contains("BusinessProcess1"))
                        {
                            if (ex is FormatException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Corrective action taken in OperatingProcedure1");
                            }
                            else if (ex is DivideByZeroException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                                // re-throw the original exception
                                throw;
                            }
                            else
                            {
                                // create a new exception object that wraps the original exception
                                throw new ApplicationException("An error occurred - ", ex);
                            }
                        }
                    }
                }
            */

            //unit 3 code:
            /*
            // Prompt the user for the lower and upper bounds
            Console.Write("Enter the lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            decimal averageValue = 0;

            // Calculate the sum of the even numbers between the bounds
            averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

            // Display the value returned by AverageOfEvenNumbers in the console
            Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

            // Wait for user input
            Console.ReadLine();

            static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
            {
                int sum = 0;
                int count = 0;
                decimal average = 0;

                for (int i = lowerBound; i <= upperBound; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                        count++;
                    }
                }

                average = (decimal)sum / count;

                return average;
            }
            */

            //unit 3b
            /*
            // Prompt the user for the lower and upper bounds
            Console.Write("Enter the lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            decimal averageValue = 0;

            bool exit = false;
            do
            {
                try
                {
                    // Calculate the sum of the even numbers between the bounds
                    averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                    // Display the result to the user
                    Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

                    exit = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("An error has occurred.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"The upper bound must be greater than {lowerBound}");
                    Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
                    string? userResponse = Console.ReadLine();
                    if (userResponse.ToLower().Contains("exit"))
                    {
                        exit = true;
                    }
                    else
                    {
                        exit = false;
                        upperBound = int.Parse(userResponse);
                    }
                }
            } while (exit == false);

            static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
            {
                int sum = 0;
                int count = 0;
                decimal average = 0;

                for (int i = lowerBound; i <= upperBound; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                        count++;
                    }
                }

                average = (decimal)sum / count;

                return average;
            }  
            */

            //unit 4 - challenge exercise
            //code:
            /*
            string[][] userEnteredValues = new string[][]
            {
                        new string[] { "1", "2", "3"},
                        new string[] { "1", "two", "3"},
                        new string[] { "0", "1", "2"}
            };

            try
            { 
                Workflow1(userEnteredValues);
                Console.WriteLine("'Workflow1' completed successfully.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
            }

            static void Workflow1(string[][] userEnteredValues)
            {
                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        Process1(userEntries);
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }

            static void Process1(String[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {
                            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                        }
                    }
                    else
                    {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                }
            }
            */  
//        }
    
//    }
//}


////////////
//OUTPUT:
//C:\Temp\CsharpProjects\TestProject\DebugTest\Program.cs(58,25): warning CS8602: Dereference of a possibly null reference.
//FormatException: User input values in 'BusinessProcess1' must be valid integers

//output 2:
// User entered value: 1
// The input string 'two' was not in a correct format.
// User entered value: 0
// User entered value: 1
// User entered value: 2

//output 3:
/*
C:\Temp\CsharpProjects\TestProject\DebugTest\Program.cs(94,17): warning CS8602: Dereference of a possibly null reference.
FormatException: User input values in 'BusinessProcess1' must be valid integers
Corrective action taken in OperatingProcedure1
DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero
Partial correction in OperatingProcedure1 - further action required
DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero
Exiting application.
*/

/*
Things to avoid when throwing exceptions
The following list identifies practices to avoid when throwing exceptions:

Don't use exceptions to change the flow of a program as part of ordinary execution. 
Use exceptions to report and handle error conditions.
Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
Don't throw System.Exception, System.SystemException, System.NullReferenceException, 
or System.IndexOutOfRangeException intentionally from your own source code.
Don't create exceptions that can be thrown in debug mode but not release mode. 
To identify runtime errors during the development phase, use Debug.Assert instead.

note:
The Debug.Assert method is a tool for catching logic errors during development. 
By default, the Debug.Assert method works only in debug builds. 
You can use Debug.Assert in debug sessions to check for a condition that should never occur. 
The method takes two parameters: a Boolean condition to check, 
and an optional string message to display if the condition is false. 
Debug.Assert should not be used in place of throwing an exception, 
which is a way to handle exceptional situations during normal execution of your code. 
You should use Debug.Assert to catch errors that should never occur, 
and use exceptions to handle errors that could occur during normal execution of your program.

Recap:
1. When creating and throwing an exception, 
the exception type must match the intended purpose of the exception as closely as possible.
2. To throw an exception, you create an instance of an exception-derived class, 
configure its properties, and then use the throw keyword.
3. When creating an exception object, it's important to provide clear error 
messages and additional information to help users correct the issue.
*/

/////////////////////////////////////////////////////
//Unit 3 - Exercise - Create and throw an exception
//OUTPUT:
//Enter the lower bound: 3
//Enter the upper bound: 11
//The average of even numbers between 3 and 11 is 7.
/// 
/// 2nd exercise
/// Catch the exception in the calling code -- see above 3b code
////////// 
//Recap:
// 1. Ensure that your debug environment is configured to support your application requirements.
//2.Method code should throw an exception when an issue or condition is detected.
//3. Exceptions should be caught at a level in the call stack where they can be resolved.
////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////
//unit 4 - Exercise - Complete a challenge activity for creating and throwing exceptions
//
//Create and throw exceptions challenge
//code above ref 4
///////////
//output:
/*
 C:\Temp\CsharpProjects\TestProject\DebugTest> dotnet run
'Process1' completed successfully.

'Process1' encountered an issue, process aborted.
Invalid data. User input values must be valid integers.

'Process1' encountered an issue, process aborted.
Invalid data. User input values must be non-zero values.

An error occurred during 'Workflow1'.
Invalid data. User input values must be non-zero values.
*/
///////////////
//output:
/*
'Process1' completed successfully.

'Process1' encountered an issue, process aborted.
Invalid data. User input values must be valid integers.

An error occurred during 'Workflow1'.
Invalid data. User input values must be non-zero values.
*/
///////////////////////////////////////////////
/// SUMMARY
/*
Your goal was to gain experience creating and throwing customized exception objects that 
can be caught and handled within a catch code block.

By creating, throwing, catching, and handling customized exceptions, you simplify the process for 
exposing and correcting programmatic issues within your application. 
Customizing exceptions with information specific to your application enables you to optimize 
the explanation of issues within the application's user interface. 
Throwing exceptions within a method and using C#'s built in support for catching exception 
objects at any level within the call stack helps to ensure that issues are caught where they can be handled.

Without the ability to create and throw customized exception objects, 
your code would be more difficult to maintain and the user experience would suffer.

Reference materials
You can find additional information about using exceptions here: 
https://learn.microsoft.com/dotnet/csharp/fundamentals/exceptions/using-exceptions.

You can find additional information about creating and throwing here: 
https://learn.microsoft.com/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions.

You can find additional information about creating user defined exceptions here: 
https://learn.microsoft.com/dotnet/standard/exceptions/how-to-create-user-defined-exceptions.

You can find additional information about localized exception messages here: 
https://learn.microsoft.com/dotnet/standard/exceptions/how-to-create-localized-exception-messages.

You can find additional information about explicitly throwing exceptions here: 
https://learn.microsoft.com/dotnet/standard/exceptions/how-to-explicitly-throw-exceptions.

You can find additional information about using specific exceptions here: 
https://learn.microsoft.com/dotnet/standard/exceptions/how-to-use-specific-exceptions-in-a-catch-block.
*/
/// 
/// //////////////////////////
/////////// END OF MODULE on Exception Handling//////////////