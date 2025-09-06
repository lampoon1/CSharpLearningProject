/////////////////////////////////////////////
//2024/11/17
//Module 3: Iterate through a code block using for statement in C#
////////////////////////
//Unit 2 of 6
//Exercise - Create and configure for iteration loops  (For Loop)
//unit 3 of 6
//Exercise -  Complete a challenge activity using for and if statements
//FizzBuzz challenge
//Code challenge - implement the FizzBuzz challenge rules
/////////////////////////////////////////////////////
//1.
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/

//2
/*
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/

//3
/*
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
*/

//Use the break keyword to break the iteration statement
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/

//loop thru each element of an array
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/

//Examine the limitation of the foreach statement
//the followig code will get this error:
//C:\Temp\c#\CsharpProjects\TestProject\Program.cs(58,9): error CS1656: Cannot assign to 'name' because it is a 'foreach iteration variable' [C:\Temp
//\c#\CsharpProjects\TestProject\TestProject.csproj]
//The build failed. Fix the build errors and run again.
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") 
        name = "Sammy";
}
*/

//Overcoming the limitation of the foreach statement using the for statement
//part 2: addeing curly braces to make the code more readable...
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David") 
    { 
        names[i] = "Sammy"; 
    }
}
foreach (var name in names) 
{
    Console.WriteLine(name);
}
*/
////////////////////////////////////////
///Code challenge - implement the FizzBuzz challenge rules
/////////////////////////////////////////////
///Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
//When the current value is divisible by 3, print the term Fizz next to the number.
//When the current value is divisible by 5, print the term Buzz next to the number.
//When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
/*
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
....
*/

/*
for (int i = 0; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0)) 
    { 
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
       Console.WriteLine($"{i} - Buzz"); 
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}
*/