///////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
//2025/9/8; 9/13 reviewing again
//Module 6:  5  - Guided Project
//Debug and handle exceptions in a C# console application using Visual Studio Code
//total 6 units
////////////////////////////////////////////////////////////////////////////////
/// Unit 1 and 2
//Learning objectives
//1. Use the Visual Studio Code debugger tools to identify and correct an issue in your code logic.
//2. Implement exception handling in a C# console application using the try-catch pattern.
//3. Create and throw exceptions with customized properties.
//4. Catch exceptions at a lower level in the call stack.
//
//Prerequisites
//1. An installation of Visual Studio Code that's configured for C# application development.
//2. Ability to develop C# console applications that implement business logic using iteration statements, 
//      selection statements, and custom methods.
//3. Experience using the Visual Studio Code debugging tools for C#.
//4. Experience implementing try-catch exception handing and throwing exceptions in C# console applications.
//
//Introduction
//- develop a retail-support applications - c# console application
//- The team is working on a cash register application that manages retail transactions. 
//      You're developing the MakeChange method that manages the money till and calculates 
//      the amount of change returned to the customer. 
//      The MakeChange method tracks the number of bills of each denomination (1, 5, 10, and 20)
//      that are available in the till. 
//  The team is planning to add exception handling to the application during the code verification process.
//      code review and 
//      debugging process
//  use try-catch pattern and throw exception 
////////////////////////////////////////////
///Unit 3
/// Review and test a C# console application using sample data
/// 1.Code review: review the contents of the Program.cs file.
///     The Program.cs includes the following code sections:
///        - Top-level statements: the top-level statements simulate a series of transactions 
///          using either an array of testData or a larger number of randomly generated transactions.
///        - LoadTillEachMorning: the LoadTillEachMorning method is used to configure the 
///          cash register till with a predefined number of bills in each denomination.
///        - MakeChange: the MakeChange method is used to manage the cash till during purchase transactions.
///        - LogTillStatus: the LogTillStatus method is used to display the number 
///          of bills of each denomination currently in the till.
///        - TillAmountSummary: the TillAmountSummary method is used display 
///          a message showing the amount of cash in the till.
///  2.  Initial testing: verify that MakeChange successfully balances the money till 
///      when using the testData array to simulate transactions.
///  3.  Code debugging: isolate and correct a logic issue that's exposed 
///      when using randomly generated data.
///  4.  Verification test: perform a verification test 
///      on the code you develop in this exercise.
/// 
/*
This application manages transactions at a store check-out line. The
check-out line has a cash register, and the register has a cash till
that is prepared with a number of bills each morning. The till includes
bills of four denominations: $1, $5, $10, and $20. The till is used
to provide the customer with change during the transaction. The item 
cost is a randomly generated number between 2 and 49. The customer 
offers payment based on an algorithm that determines a number of bills
in each denomination. 

Each day, the cash till is loaded at the start of the day. As transactions
occur, the cash till is managed in a method named MakeChange (customer 
payments go in and the change returned to the customer comes out). A 
separate "safety check" calculation that's used to verify the amount of
money in the till is performed in the "main program". This safety check
is used to ensure that logic in the MakeChange method is working as 
expected.
*/
//manages the money till during each purchase transaction
//relies on the following conditions:
//cash transactions, input parameters are valid, cash available in the till,
//change owed to customer
//underpayment
//insufficient till
//////////end of unit 3 intro and explanation ////////////////////////
//////////UNIT 4 coding and testing starts here////////////
/*
string? readResult = null;
bool useTestData = true;

Console.Clear();

int[] cashTill = new int[] { 0, 0, 0, 0 };
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
//modify to use 2D integer array:
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

LoadTillEachMorning(registerDailyStartingCash, cashTill);

registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] 
                        + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] 
                        + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] 
                        + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// display the number of bills of each denomination currently in the till
LogTillStatus(cashTill);

// display a message showing the amount of cash in the till
Console.WriteLine(TillAmountSummary(cashTill));

// display the expected registerDailyStartingCash total
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random((int)DateTime.Now.Ticks);

int transactions = 40; // number of transactions to simulate, was 10

if (useTestData)
{
    transactions = testData.Length;
}

while (transactions > 0)
{
    transactions -= 1;
    int itemCost = valueGenerator.Next(2, 50);

    if (useTestData)
    {
        itemCost = testData[testCounter];
        testCounter += 1;
    }

    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

    // display messages describing the current transaction
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

    // MakeChange manages the transaction and updates the till 
    //this line: MakeChange returns a string called transactionMessage
    //string transactionMessage = MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);
    
    //updated to use try-catch block here:
    try
    {
        //unit 4: now turn the MakeChange return type to void, calling this method here:
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        Console.WriteLine($"Transaction successfully completed.");
        registerCheckTillTotal += itemCost;
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Could not complete transaction: {e.Message}");
    }  


    // Backup Calculation - each transaction adds current "itemCost" to the till
    // if (transactionMessage == "transaction succeeded")
    // {
    //     Console.WriteLine($"Transaction successfully completed.");
    //     registerCheckTillTotal += itemCost;
    // }
    // else
    // {
    //     Console.WriteLine($"Transaction unsuccessful: {transactionMessage}");
    // }

    Console.WriteLine(TillAmountSummary(cashTill));
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
    Console.WriteLine();
}

Console.WriteLine("Press the Enter key to exit");
do
{
    readResult = Console.ReadLine();

} while (readResult == null);


static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
{
    cashTill[0] = registerDailyStartingCash[0, 1];
    cashTill[1] = registerDailyStartingCash[1, 1];
    cashTill[2] = registerDailyStartingCash[2, 1];
    cashTill[3] = registerDailyStartingCash[3, 1];
}


//unit 4 modifications to MakeChange method: added exception on changeNeeded < 0 and changeNeeded > 0
//also changed return type from string to void here:
static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    //string transactionMessage = "";

    cashTill[3] += twenties;
    cashTill[2] += tens;
    cashTill[1] += fives;
    cashTill[0] += ones;

    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
    int changeNeeded = amountPaid - cost;

    // if (changeNeeded < 0)
    //     transactionMessage = "Not enough money provided.";
    //updated code to catch error and write out custom error message here:
    if (changeNeeded < 0)
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");

    Console.WriteLine("Cashier Returns:");

    while ((changeNeeded > 19) && (cashTill[3] > 0))
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0))
    {
        cashTill[1]--;
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0))
    {
        cashTill[0]--;
        changeNeeded--;
        Console.WriteLine("\t A one");
    }

    // if (changeNeeded > 0)
    //     transactionMessage = "Can't make change. Do you have anything smaller?";
    //updated code to catch error and write out custom error message here:
    if (changeNeeded > 0)
        throw new InvalidOperationException("InvalidOperationException: The till is unable to make the correct change.");

    // if (transactionMessage == "")
    //     transactionMessage = "transaction succeeded";
    //return transactionMessage;
}

static void LogTillStatus(int[] cashTill)
{
    Console.WriteLine("The till currently has:");
    Console.WriteLine($"{cashTill[3] * 20} in twenties");
    Console.WriteLine($"{cashTill[2] * 10} in tens");
    Console.WriteLine($"{cashTill[1] * 5} in fives");
    Console.WriteLine($"{cashTill[0]} in ones");
    Console.WriteLine();
}

static string TillAmountSummary(int[] cashTill)
{
    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

}
*/


////////////////////////////////////////////
//unit 3 notes: 
/// making final corrections
/// first, Verify that MakeChange successfully manages the money when using the testData array
/// Run the code using debugging mode
/// notice IOException
/// on the debug toolbar, select stop
/// open launch.json file, update the console attribute to "integratedTerminal"
/// note: default value for the console attribute is internalConsole,   
/// 
/// OUTPUT:
/*
Transaction successfully completed.
The till has 379 dollars
Expected till value: 434


Press the Enter key to exit

*/
//////////////////////////////////////
/// Unit 4 of 6  --Throw and catch exceptions in a C# console application
/// continue modifying and working with the above codebase
/// 
/// develop try-catch
/// - the try code block will contain the call to MakeChange.
/// - update MakeChange method: Create and throw exceptions for "Insufficient till" and "Underpayment" issues
/// - update the catch code block to use properties of the thrown exception.
/// - perform Verification tests for the code that you develop in this exercise.
/// 
/// /////////
/// OUTPUT:  I think my code is incorrect, the till keep increasing amount and I do not see the exception being thrown
/// ///////// /
/*
 The till currently has:
100 in twenties
100 in tens
100 in fives
50 in ones

The till has 350 dollars
Expected till value: 350

Customer is making a $6 purchase
         Using 1 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A ten
         A one
         A one
         A one
         A one
Transaction successfully completed.
The till has 356 dollars
Expected till value: 356
...

...
Transaction successfully completed.
The till has 510 dollars
Expected till value: 510
The till currently has:
100 in twenties
100 in tens
100 in fives
50 in ones

The till has 350 dollars
Expected till value: 350

Customer is making a $10 purchase
         Using 1 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A ten
Transaction successfully completed.
The till has 366 dollars
Expected till value: 366


Customer is making a $17 purchase
         Using 1 twenty dollar bills
         Using 1 ten dollar bills
         Using 0 five dollar bills
         Using 1 one dollar bills
Cashier Returns:
         A ten
         A one
         A one
         A one
         A one
Transaction successfully completed.
The till has 383 dollars
Expected till value: 383



Customer is making a $31 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 1 one dollar bills
Cashier Returns:
         A ten
Transaction successfully completed.
The till has 434 dollars
Expected till value: 434



Customer is making a $40 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
Transaction successfully completed.
The till has 510 dollars
Expected till value: 510


Customer is making a $41 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 1 one dollar bills
Cashier Returns:
Transaction successfully completed.
The till has 551 dollars
Expected till value: 551


Press the Enter key to exit
*/
/////////////////////////////
/// RECAP
/// debugged the cash register application to fix a code logic issue, 
/// updated the application to use proper exception handling techniques.
/// 
/// NOTE:
/// The reported output shows that the money till is no longer balanced. 
/// There are additional logic bugs in the code. 
/// A challenge project module is available if you're interested in 
/// demonstrating your Visual Studio Code debugging skills!
/// 
/// SUMMARY
/// Your goal was to gain experience with the Visual Studio Code debugger, 
/// implement a try-catch pattern, and create and throw exceptions 
/// that are caught at a lower level of the call stack.
/// 
/// By reviewing the cash register application, debugging the MakeChange method, 
/// and implementing exception handling techniques in both the method and calling code, 
/// you gained the experience you wanted. 
/// 
/// You used the debugger tools to configure a breakpoint in the top-level 
/// statements of the application. With execution paused, you stepped through the code 
/// to isolate an issue in the code logic. 
/// 
/// You implemented a try-catch pattern in the top-level statements, 
/// created and threw an InvalidOperationException exception in the MakeChange method, 
/// and then updated the catch clause to catch only the InvalidOperationException exception type.
/// 
/// The ability to debug C# applications and implement exception handling 
/// enables you to develop stable and reliable applications.
/////////////////////////////////////////////////////////////////
/// 
/// //2025/9/13 review
/// --build and run again; fixed previous file (Program_Mod6_....cs)
///      that has some code there causing not errors but warning
/// --fix: I can open the debugger by open the folder that has the .csproj, 
/// in my case, do File -> open folder-- > C:\Temp\DebugTest\
/// since I moved this folder out of C:\Temp\CsharpProjects\TestProject\
/// and save file and press F5 did start the debugger!
/// 
/// OUTPUT: 
/*
The till currently has:
100 in twenties
100 in tens
100 in fives
50 in ones

The till has 350 dollars
Expected till value: 350

Customer is making a $6 purchase
         Using 1 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A ten
         A one
         A one
         A one
         A one
Transaction successfully completed.
The till has 356 dollars
Expected till value: 356


Customer is making a $10 purchase
         Using 1 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A ten
Transaction successfully completed.
The till has 366 dollars
Expected till value: 366


Customer is making a $17 purchase
         Using 1 twenty dollar bills
         Using 1 ten dollar bills
         Using 0 five dollar bills
         Using 1 one dollar bills
Cashier Returns:
         A ten
         A one
         A one
         A one
         A one
Transaction successfully completed.
The till has 383 dollars
Expected till value: 383


Customer is making a $20 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A twenty
Transaction successfully completed.
The till has 403 dollars
Expected till value: 403


Customer is making a $31 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 1 one dollar bills
Cashier Returns:
         A ten
Transaction successfully completed.
The till has 434 dollars
Expected till value: 434


Customer is making a $36 purchase
         Using 2 twenty dollar bills
         Using 1 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
         A ten
         A one
         A one
         A one
         A one
Transaction successfully completed.
The till has 470 dollars
Expected till value: 470


Customer is making a $40 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 0 one dollar bills
Cashier Returns:
Transaction successfully completed.
The till has 510 dollars
Expected till value: 510


Customer is making a $41 purchase
         Using 2 twenty dollar bills
         Using 0 ten dollar bills
         Using 0 five dollar bills
         Using 1 one dollar bills
Cashier Returns:
Transaction successfully completed.
The till has 551 dollars
Expected till value: 551


Press the Enter key to exit
*/
/////////////////////////////////////////////////////////////
/////////// END OF MODULE on Exception Handling//////////////
/// ////////////////////////////////////////////////////////////////////////////