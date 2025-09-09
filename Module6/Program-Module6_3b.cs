//////////////////////////////////////////////////////////////////////////////
//2025/9/6; 2025/9/8
//Module 6:  4 - create and throw exceptions in C# Console Applications
//Total 7 units
////////////////////////////////////////////////////////////////////////////////
//Learning objectives
//1. Learn how exception objects are created and how to customize their property settings.
//2. Develop C# console applications that create and throw customized exception objects.
//3. Develop C# console applications that catch custom exception objects and manage exception property information.
//////////////////////////////////////////////////
//notes
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

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            // completes required calculations based on userValue
            // ...
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}
*/
///////////////////////////////////////////////////////////
/////////////////End of this module////////////////////////////////////////