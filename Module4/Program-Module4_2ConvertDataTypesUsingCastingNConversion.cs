/////////////////////////////////////////////
//2024/12/4 
//Module 4: Work with variable data in C# Console Applications
//PART 2  - Convert data types using casting and conversion techniques in C#
////////////////////////
/*
Prerequisites
Experience using data types like string, int, decimal, float, and so on
Experience using arrays and the foreach iteration statement
Experience using string interpolation to combine variable and literal values for output
Experience using Visual Studio Code to develop, build, and run C# codeld, and run C# code.
*/
//////////////////////
//Unit 1 of 9
//Objective
//Use the casting operator to cast a value into a different data type.
//Use conversion methods to convert a value into a different data type.
//Guard against the loss of data when performing a cast or conversion operation.
//Use the TryParse() method to safely convert a string into a n
////////////////////////
//Unit 2 of 9
//Exercise - Explore data type casting and conversion
//write code to add int and string, and save result in an int
/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);
*/
/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");


decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

//Using ToString() to convert a number to a string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//convert a string to an int using the PArse() helper method:
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//Compare casting and converting a decimal into an int
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
*/
//////////////////////
//Unit 3 of 9
//Exercise - Examine the TryParse() method
//string name = "Bob";
//Console.WriteLine(int.Parse(name));
//
//Output:
//System.FormatException: 'Input string was not in a correct format.'

/*
//TryParse() a string into an int
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
*/

/*
//Use the parsed int later in code
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

/*
//Modify the string variable to a value that can't be parsed
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//output
//   Unable to report the measurement.
*/

/*
Recap
The TryParse() method is a valuable tool. Here are few quick ideas to remember.

Use TryParse() when converting a string into a numeric data type.
TryParse() returns true if the conversion is successful, false if it's unsuccessful.
Out parameters provide a secondary means of a method returning a value. In this case, the out parameter returns the converted value.
Use the keyword out when passing in an argument to a method that has defined an out parameter.
*/

///////////////////////
//Unit 4 of 9; 5 of 9
//Exercise - Complete a challenge to combine string array values as strings and as integers 
/*
//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
output:
Message: ABCDEF
Total: 68.3
*/
/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

//////////////////////////////////
//Unit 6 of 9
//Exercise - Complete a challenge to output math operations as specific number types
//
/*
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1/value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
//decimal result2 = Convert.ToDecimal(value2/value3);
//suggested solution
decimal result2 = value2/ (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
//double result3 = Convert.ToDouble(value3/value1);
//solution:
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
//output:
//Divide value1 by value2, display the result as an int: 2
//Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
//Divide value3 by value1, display the result as a float: 0.3909091
*/
//unit 7/9 --review questions/quiz
/////////////////////////////////////////////////////////////////////////////