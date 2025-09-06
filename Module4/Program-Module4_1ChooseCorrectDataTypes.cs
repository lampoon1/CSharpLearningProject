/////////////////////////////////////////////
//2024/12/2; 12/4 
//Module 4: 
//Work with variable data in C# Console Applications
//PART 1
//Choose the correct data type in your C# code
////////////////////////
/*
Prerequisites
Experience using basic data types like string, char, bool, int, and decimal.
Experience using string interpolation to combine variables in string templates.
Experience using code comments to comment out unused code.
Experience using Visual Studio Code to develop, build, and run C# code.
*/
//////////////////////
///
//Unit 1 of 8
//Learn the fundamental differences between value types and reference types.
////////////////////////
//Unit 2 of 8
/*
Discover value types and reference types
RECAP
Values are stored as bits, which are simple on / off switches. Combining enough of these switches allows you to store just about any possible value.
There are two basic categories of data types: value and reference types. The difference is in how and where the values are stored by the computer as your program executes.
Simple value types use a keyword alias to represent formal names of types in the .NET Library.
*/
//////////////////////
//Unit 3 of 8
//Exercise - Discover integral types
///////////////////////
//Unit 4 of 8
//Exercise - Discover floating-point types
///////////////////////
//Unit 5 of 8
//Exercise - Discover reference types
///////////////////////
//Unit 6 of 8
// Choose the right data type
//unit 7: review questions; unit 8 is download a unit completed cert.
//////////////////////////////////////////////////////////
//starts unit 3 code...
/*
//Use the MinValue and MaxValue properties for each signed integral type
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
//Unsigned integral types
//An unsigned type uses its bytes to represent only positive numbers. The remainder of the exercise introduces the unsigned integral types in C#.
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
*/

///////////////////////////////////////////////////////
//starts unit 4 code...
/*
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

//////////////////////////////////////////////////////////
/*
//starts unit 5 code here...
//int[] data;
//int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");
*/

/////////////////////////////////////////////////
//starts unit 6 review explanation on how to choose correct
//data type, no code...
/*
When in doubt, stick with the basics
While you've looked at several considerations, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:

int for most whole numbers
decimal for numbers representing money
bool for true or false values
string for alphanumeric value
Choose specialty complex types for special situations
Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:

byte: working with encoded data that comes from other computer systems or using different character sets.
double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
System.DateTime for a specific date and time value.
System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
*/