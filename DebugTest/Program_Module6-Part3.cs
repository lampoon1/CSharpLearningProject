// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/// Tutorial 1: learn to set breakpoint
/// set it on line with (numbers[5]) and run debugger
/// Tutorial 2: more Exceptions in various 
/// DivideByZero and still learning to set breakpoints
/// NullReference
/// FileNotFound
/// ////////////////////////////////////////////////////////////////////////////////////
/// Tutorial 3: From TestProject\Module 6 and challenge activity on exception handling
///unit 8 of 11 -Complete a challenge activity to catch specific exceptions
/// Exercise - Catch specific exceptions challenge
/// 
////////////////////////////////////////////////////////// 
/*
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Starting exception demo...");

        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]);  // <-- set a breakpoint here
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Caught an exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block always runs.");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
*/
//////////////////////////////////////////////
////////////////////////////////////////////////////////// 
/*
 using System;
using System.IO;

class Program
{
    // 👇 Change this to 1, 2, or 3 to run each exercise
    static int EXERCISE = 1;

    static void Main()
    {
        Console.WriteLine($"Starting Exception Lab (Exercise {EXERCISE})\n");

        switch (EXERCISE)
        {
            case 1: DivideByZero_Handled();  break;
            case 2: NullReference_Handled(); break;
            case 3: FileNotFound_Handled();  break;
            default: Console.WriteLine("Set EXERCISE = 1, 2, or 3 at top of file."); break;
        }

        Console.WriteLine("\nDone.");
    }

    // ========= EXERCISE 1: DivideByZero =========
    static void DivideByZero_Unhandled()
    {
        Console.WriteLine("[1] DivideByZero (unhandled) — set breakpoint on the division");
        int a = 5;
        int b = 0;

        // ⛳ Breakpoint here
        int result = a / b;   // throws System.DivideByZeroException for ints

        Console.WriteLine($"Result = {result}");
    }

    static void DivideByZero_Handled()
    {
        Console.WriteLine("[1] DivideByZero (handled) — try/catch");

        int a = 5;
        int b = 0;

        try
        {
            // ⛳ Breakpoint here
            int result = a / b;
            Console.WriteLine($"Result = {result}");
        }
        catch (DivideByZeroException ex) when (b == 0) // example of exception filter
        {
            Console.WriteLine($"Caught: {ex.GetType().Name} — {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally (always runs).");
        }
    }

    // ========= EXERCISE 2: NullReference =========
    static void NullReference_Unhandled()
    {
        Console.WriteLine("[2] NullReference (unhandled) — set breakpoint on the line using 'name'");

        string? name = null;

        // ⛳ Breakpoint here
        int len = name.Length;  // throws System.NullReferenceException

        Console.WriteLine($"Name length = {len}");
    }

    static void NullReference_Handled()
    {
        Console.WriteLine("[2] NullReference (handled)");
        string? name = null;

        try
        {
            // ⛳ Breakpoint here
            int len = name!.Length; // '!' suppresses warnings, still throws if null
            Console.WriteLine($"Name length = {len}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Caught: {ex.GetType().Name} — {ex.Message}");
            // Safer alternatives:
            int safeLen = name?.Length ?? 0;   // null-conditional + coalesce
            Console.WriteLine($"Safe length using ?. and ?? = {safeLen}");
        }
    }

    // ========= EXERCISE 3: FileNotFound =========
    static void FileNotFound_Unhandled()
    {
        Console.WriteLine("[3] FileNotFound (unhandled)");
        Console.WriteLine($"Working directory: {Directory.GetCurrentDirectory()}");

        // Intentionally read a missing file
        string path = "missing.txt";

        // ⛳ Breakpoint here
        string content = File.ReadAllText(path);  // throws System.IO.FileNotFoundException

        Console.WriteLine($"File content: {content}");
    }

    static void FileNotFound_Handled()
    {
        Console.WriteLine("[3] FileNotFound (handled)");
        Console.WriteLine($"Working directory: {Directory.GetCurrentDirectory()}");

        string path = "missing.txt";
        try
        {
            // ⛳ Breakpoint here
            string content = File.ReadAllText(path);
            Console.WriteLine($"File content: {content}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Caught: {ex.GetType().Name}");
            Console.WriteLine($"Missing file: {ex.FileName ?? Path.GetFullPath(path)}");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Caught: {ex.GetType().Name} — {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Caught general I/O error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Cleanup or fallback goes here.");
        }
    }
}
*/
//////////////////////////////////////////////////////////////
//
//Exercise - Complete a challenge activity for try-catch
//Code starts
/*
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    //catch (Exception ex) //first try  this from System.Exception 
    // next, do this specific exception type:  System.DivideByZeroException
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    //Console.WriteLine(float1 / float2);
    //Console.WriteLine(number1 / number2);

    //Console.WriteLine(float1 / float2);
    // Console.WriteLine(number1 / number2);
    //checked
    //{
    //    smallNumber = (byte)number1;
    //}

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
    {
        try
        {
            smallNumber = (byte)number1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
        }  
    }
}

//expect output:
//Exception caught in Process1
//
//Exception caught in Process1
//Exit program
//
//Exception thrown: 'System.DivideByZeroException' in Exceptions101.dll
//The program '[436] Exceptions101.dll' has exited with code 0 (0x0).
*/
//////////////////////////////////////////
/*
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");
*/


//OUTPUT:
// Error: The number is too large to be represented as an integer. Arithmetic operation resulted in an overflow.
// Error: The reference is null. Object reference not set to an instance of an object.
// Error: Index out of range. Index was outside the bounds of the array.
// Error: Cannot divide by zero.Attempted to divide by zero.
// Exiting program.
////////////////////////////////////
/// SUMMARY
/*
Your goal was to gain experience implementing exception handling in C# applications using Visual Studio Code.

By examining the properties of common exception types and experimenting with the try-catch pattern, you gained experience catching runtime exceptions. You used exception handling to catch exceptions in the method where they occurred and at a lower level of the call stack. You also practiced using two or more catch clauses to catch different exception types associated with a single try code block.

Without the ability to implement exception handling, you wouldn't be able to delivery stable and reliable C# applications.

Reference materials
You can find additional information about exception properties here: https://learn.microsoft.com/dotnet/standard/exceptions/exception-class-and-properties and https://learn.microsoft.com/dotnet/api/system.exception.

You can find additional information about exceptions here: https://learn.microsoft.com/dotnet/csharp/language-reference/language-specification/exceptions.

You can find additional information about using specific exception types here: https://learn.microsoft.com/dotnet/standard/exceptions/how-to-use-specific-exceptions-in-a-catch-block.

You can find additional information about the try-catch-finally patterns here: https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-catch-finally.
*/
/// /////////////////////////////////////////////////////
/// END OF MODULE on Exception Handling//////////////