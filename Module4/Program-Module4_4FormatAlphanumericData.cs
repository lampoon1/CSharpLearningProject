/////////////////////////////////////////////
//2024/12/4; 2024/12/12
//Module 4: Work with variable data in C# Console Applications
//PART 4  - Format alphanumeric data for presentation in C#
////////////////////////
/*
Prerequisites
Introductory experience with creating and initializing variables of type string and decimal
Introductory experience with literal values of type string and decimal
Introductory experience with Console.WriteLine()
Experience using Visual Studio Code to develop, build, and run C# code

Use character escape sequences to add tabs, new lines, and Unicode characters to our strings.
Create verbatim string literals, and escape common characters like backslash ( \ ) and double-quotes ( "" ).
Merge templates with variables using composite formatting and string interpolation.
Include various format specifiers for percentages, currency, and numbers.
*/
//////////////////////
//Unit 1 of 8
//////////////////////
//Intro:
/*
From a high-level perspective, software developers are concerned with:

1. data input, including data typed in by a user from a keyboard, using their mouse, a device, or by another software system via a network request.
2. data processing, including decision logic, manipulating data, and performing calculations.
3. data output, including presentation to an end user via a command-line message, a window, a web page,
        or saving the processed data into a file, and sending it to a network service.

To solve business problems in C#, you need to work with different types of data, 
such as strings and numbers. You also need to perform various operations on the data, 
such as calculations, comparisons, or conversions. In this module, 
you output string and numeric data in C# using various formatting options. 
You also create a receipt mockup and a personalized marketing message using data merging techniques.
*/

//objectives:
//Merge string templates with variables using composite formatting.
//Use various format specifiers to properly display percentages, currency, and numbers.
//Use padding methods to properly align string values.

//////////////////////////////////////////////////
//////Unit 2 of 8
//////Exercise - Investigate string formatting basics
////////////////////////////////////////////
//start coding here

//composite formatting: uses numbered placeholders within a string. 
//  
/*                    At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//output: Hello World!

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//output: 
//Hello World!
//Hello Hello Hello!

*/

//What is string interpolation? a technique that simplifies composite formatting.
/*
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
*/
//OUTPUT:
/*
Hello World!
World Hello!
Hello Hello Hello!
*/
//Formatting currency
//Code:
/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
*/
//expected output:
//Price: $123.45 (Save $50.00)
//explanation:
//adding the :C to the tokens inside of the curly braces formats the number as currency regardless of whether you use int or decimal.
//user's country/region and language affect string formatting
//if user in France: the output will look like:
//Price: 123,45 € (Save 50,00 €)

//Formatting numbers
//Code:
/*
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
*/
//expected output:
//Measurement: 123,456.79 units
//by default, the N numeric format specifier displays only two digits after the decimal point.
//if display more precision:
/*
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
*/
//output: Measurement: 123,456.7891 units

//Formatting percentages
//Code:
//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P2}");
//output: Tax rate: 36.79%
//explanation: Use the P format specifier to format percentages and rounds to 2 decimal places. 
//Add a number afterwards to control the number of values displayed after the decimal point. 

//Combining formatting approaches
//Code:
/*
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
*/
//output: You saved $7.56 off the regular $67.55 price.
/////////
///NOTE: You don't need to use String.Format() with this string interpolation approach.
//////////
//updating code as follows:
/*
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
*/
//OUTPUT: You saved $7.56 off the regular $67.55 price. A discount of 11.19%!
/////////////////////////////////////////////
///RECAP of unit 2:
///Recap
//You can use composite formatting or string interpolation to format strings.
//With composite formatting, you use a string template containing one or more replacement tokens in the form {0}. You also supply a list of arguments that are matched with the replacement tokens based on their order. Composite formatting works when using string.Format() or Console.WriteLine().
//With string interpolation, you use a string template containing the variable names you want replaced surrounded by curly braces. Use the $ directive before the string template to indicate you want the string to be interpolated.
//Format currency using a :C specifier.
//Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like {myNumber:N3}.
//Format percentages using the :P format specifier.
//Formatting currency and numbers depend on the end user's culture, a five character code that includes the user's country/region and language (per the settings on their computer)
/////////////////////////////////////////////////////////
///Unit 3 of 8
///Exercise - Explore string interpolation
//////////////////////////////////////////
//1. Display invoice number using string interpolation
/* int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}"); */

//OUTPUT (with warnings...): Invoice Number: 1201
//2nd output:
//Invoice Number: 1201
//   Shares: 25.457 Product
//3rd output:
// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//4th output:
// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//            Tax: 15.83%
//////////////
//Finalize the receipt with the total amount due formatted as currency:
//output:
/*
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19
*/
//========================================     
//unit 4 of 8
//Discover padding and alignment
///////////////////////////////////////
/*
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
*/
//output: Hello World!
//
//Formatting strings by adding whitespace before or after
///code:
//string input = "Pad this";
 //Console.WriteLine(input.PadLeft(12));
 //output:
 //    Pad this
 ///////////////
// Console.WriteLine(input.PadRight(12));
//
//output and explanation: This will space or characters to the right side of your string, 
//use the PadRight() method instead. 
//You won't observe any characters added to the end of the string, but they're there.
////////////////////////////////////
///
///What is an overloaded method?
///
//n C#, an overloaded method is another version of a method with different or extra arguments that 
//modify the functionality of the method slightly, as is the case with the overloaded version of the PadLeft() method.
//You can use the PadLeft() method, and pass in a character you want to use instead of space
//CODE:
//Console.WriteLine(input.PadLeft(12, '-'));
//Console.WriteLine(input.PadRight(12, '-'));
 //OUTPUT:
// ----Pad this
//Pad this----
////////////////
//Working with padded strings: Add the Payment ID to the output
//CODE:
//string paymentId = "769C";
// var formattedLine = paymentId.PadRight(6);
// Console.WriteLine(formattedLine);
//OUTPUT: 769C
////////////
/* string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);

 Console.WriteLine(formattedLine); */
//output and explanation:
//The += operator performs a string concatenation, 
//taking the previous value of the variable formattedLine and adding the new value to it. 
//769C  Mr. Stephen Ortega
//////////
//Code: add the payment amount to the output:
/* string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine(formattedLine); */
 //output:
// 769C  Mr. Stephen Ortega       $5,000.00
//next, Add a line of numbers above the output to more easily confirm the result
///CodE:
/* string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine); */
 //output and explanation of seeing the result in correct lining/position:
//1234567890123456789012345678901234567890
//769C  Mr. Stephen Ortega       $5,000.00
////////////////////////////
///RECAP unit 4
//The string data type, literal strings, and variables of type string each implement many helper methods to format, 
//modify, and perform other operations on strings.
//The PadLeft() and PadRight() methods add white space (or optionally, another character) to the total length of a string.
//Use PadLeft() to right-align a string.
//Some methods are overloaded, meaning they have multiple versions of the method with different arguments that affect their functionality.
//The += operator concatenates a new string on the right to the existing string on the left.
//Quiz question:
// Given string myWords = "Learning C#", what is the best output description for Console.WriteLine(myWords.PadLeft(12));? 
//answer: one space is added.   myWords is 11 characters long, adding on space completes the padding to 12.

//////////////////////////////////////
///UNIT 5 of 8; UNIT 6 of 8
/////////////////////
//Exercise - Complete a challenge to apply string interpolation to a form letter
//REVIEW solution on unit 6 or 8 and explanation
//
//output:
/* 
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00 
*/
//start of code:
/* string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage); */
///conclude the challenge exercise, the above code ran with the expected output and its format.
/////alternative:
///Composite formatting such as Console.WriteLine("Dear {0},", customerName) is another possible solution.
//The second part of the solution displays the comparison table by building a long string step by step using string concatenation, 
//string.Format() with composite formatting, format specifiers (percent and currency), and PadRight().
//The following code builds the first line of the table with additions of Console.WriteLine() 
//after each step of building the string comparisonMessage.
////////////////////////////////////////////
/////SUMMARY:
///You exercised different techniques for merging a string template with variables using composite formatting and string interpolation. 
//The various specifiers allow you to properly format large numbers, currency, and percentages. 
//The built-in methods on variables of type string allowed you to add padding to left and right align data.
//
//Imagine how much extra work is required if you didn't have a wealth of string and number formatting tools and 
//techniques available to you in C#. You would likely attempt to use string concatenation everywhere, 
//possibly making it difficult to maintain or update.
///Resources
//String.Format Method (https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0&preserve-view=true)
//Standard Numeric Format Strings (https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)
//////////////////////////////////////////////////////