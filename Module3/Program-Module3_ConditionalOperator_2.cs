/////////////////////////////////////////////
//2024/11/16; 11/17
//Module 3: Add logic to C# console applications (Get started with C#, Part 3)  
//Control variable scope and logic using code blocks in C#
////////////////////////
//Unit 2 of 7
//Exercise - Code blocks impact the scope of a variable declaration
//unit 3 of 7
//Exercise - Remove code blocks from if statements
//unit 4 of 7
//Exercise - Complete a challenge activity using variable scope
/////////////////////////////////////////////////////
/*
bool flag = true;
int value = 0;
if (flag)
{
   
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/

//examine these 2 following code example
//1
// Code sample 1
/*
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/
//example 2
// Code sample 2
/*
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/
/////////////////////////////////////////////////////////////////
///unit 3
/////1
/*
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
*/
//Examine the readability of single-line form if statements
/*
bool flag = true;
if (flag)
    Console.WriteLine(flag);
*/
/*
bool flag = true;
if (flag) Console.WriteLine(flag);
*/
/*
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/
/*
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
*/

//exercise 4 of 7
//Code challenge: update problematic code in the code editor
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{ 
    total += number;
    if (number == 42)
       found = true;
}
if (found) 
    Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");
*/