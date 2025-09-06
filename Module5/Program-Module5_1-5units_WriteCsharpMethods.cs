////////////////////////////////////////////////////
//2025/1/24, 2025/9/6
//Module 5:  total 9 units - Write your first C# Method
////////////////////////
/// prereq 2025/9/6
/// 1. open VS code, get familiar with this IDE, left, right and bottom panels
/// 2. refresh memory what I know i c#: how to create a console app in VS code
/// 3. know data types, create variables, instantiating them, sending output to a console window
/// 4. c# data types are int, string, double, bool, arrays
/// 5. using switch, if, if-else statements and for loops, 
/// 6. using string.Split
/// 7. ok, restart my learning journey and keep going :)
///////
//Unit 1 of 9 -- Prep
//Unit 2 of 9 -- Calling a method
//
//what you may already know: Console.Writeline() and randowm.Next()
//Objective:
//Create your first c sharp method
//Identify parts of code that can be modularized
//Use methods to organize code into specific tasks
//OUTPUT
//////////////////////////////////////////////////
/////unit 2 of 9 
///start exercise - Understand the syntax of methods
/// 1. how method works: create method signature, method name with a () parenthesis,
///     and a definition
///     this is called SayHello
///     return type is void (no data)
///     using () next to method namem and a ; to end
/// 2. other metho example if you want the method to return data:
///     use int bool double
///     say public int SayHello(); expects it to return an integer
/// 3. Because this is a refresher for me and learning this exercise again, I now learned that
///    commented out other project code first
///    right clidk to this current file, and choose open terminal
///    then type: dotnet build and dotnet run will display the output. SUCCESS!
///////////////////////////////////////////////////
//the below method will print Hello World when it's called, try it
/*
SayHello();

//this is call a 
void SayHello() 
{
    Console.WriteLine("Hello World!");
}
*/
///////////////////////////////////////////////////
/// unit 2 of 9 -- Calling a method learning next is 
/// to have the method definied before it's called
/*
int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
*/
/*
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello() 
{
    Console.WriteLine("Hello World!");
}
*/
//Best practices:
// keep the methid name concise 
// try to and make it clear what task the method performs. 
// Method names generally shouldn't start with digits, starts with a letter or underscore(_)
// Names for parameters should describe what kind of information the parameter represents. 
// 
// Examples of method signatures:
//void ShowData(string a, int b, int c);
//void DisplayDate(string month, int day, int year);
//2nd method is better and describes what kind of data is displayed and provides descriptive names for parameters.
////////////////////////////////////////////////////////////////
//unit 3
//Create your first method

//a brief intro to say open VS Code, windows start menu,  File, Open Folder
//browse to your folder that has this project, Select folder, Open VS Code Terminal menu, select
//New Terminal, a command prompt panel will say folder path...OK GOT IT!
//Extra information that I learned:
//  using Terminal command to create the console app: dotnet new console -o MyFirstApp 
//  dotnet new -o ./path/path/MyFirstApp press enter
//  this .NET CLI command uses a .NET program template to create a new C# Console app. then use
//  explorer to to expand the folder and open the Program.cs file and start coding...
//
// I ran this code and I learn
// create a method by delcaring a return type, name, input param, and method body
// method name reflect what it does; call the method with () parenthesis
// using for loop to extend the method further 
/*
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
*/
//////////////////////////////////////////////////
/////unit 4 of 9  -- create reusable methods
/// //
/// //in your real life project, when you need to do task repeatedly, then writing a method 
/// that can be called multiple times is a good idea. 
/// 1. indentify duplicated code
/// In the exercise below, there's several for-loops that are repeated with identical code.
/// repeated code are: format and display time, and adjust times with some calculation
/// 2. understand what I need to do and try replace repeated code into a method
/// once indentified the repeated code, create a method for each task...
/// they are: AdjustTimes() and DisplayTimes()
/// 3. call the method where needed; test and verify it works, see below...
/// 4. Learned: when I run this method, I have no idea what to input, I did 11:22AM and got errors
///  further improrvment in instructions needed (expects an integer)
///  I created errors when I type: 1.5, a etc. 
/// 5. Check Your Work
//  run this code from the Integrated Terminal and verify it is working correctly.
//  NOTE: Ctrl + S to save code
//  At the Terminal prompt: enter dotnet run
/*
using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

//this is one of the methods created to display times and from repeated code
void DisplayTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
    Console.WriteLine();
}

//this is the 2nd method created to calculate adjust time from repeated code
void AdjustTimes() 
{
   
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
*/
//////////////////////////////////////////////////
/////unit 5 of 9  -- Build code with methods
///  Added notes: methods are useful for organizing code, reusing code and tackling problems efficiently
///  pseudo code: it is using plain language to describe steps in code
///  use methods to structure code
///  Given a problem to solve below, let's break it down:
///  a valid IPv4 address with 4 numbers separated by dots, each num not contain leading zeroes, each number
///  range from 0 to 255 e.g valid address are 1.1.1.1 and 255.255.255.255 are valid IP addresses
///  provided as a string, assume consists of a string of digits and dots, no letters, so int and dots
/// 
///  here are some of steps to be considered:
/// 1. Break down the problem
//    identify the steps needed to solve the problem. 
//    If you look closely at the rules, you might realize that it only takes three steps to determine 
//    whether or not an IPv4 address is valid.
/*
//Pseudo-code is a great way to begin tackling any problem. 
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
//1. transfer the if statement into some methods
/*
    if (validLength() && validZeroes() && validRange()) 
    {
        Console.WriteLine($"ip is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"ip is an invalid IPv4 address");
    }
*/
//2. then enter these methold holders, no logic in them yet
/*
void ValidateLength() {}
void ValidateZeroes() {}
void ValidateRange() {}
*/
/*
//3. develop your solution
// note: extra testing //file has updates and did not save first, will the terminal run and work? it will not save and use last saved code
//first declare variables:
//string ipv4Input = "107.31.1.5";
//this line added later for more testing cases
//string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    //string[] address = ipv4Input.Split(".");
    validLength = address.Length == 4;
};

//learning from this method, is to set return;
//  Adding a return statement after validZeroes = false terminates the method after the first invalid zero is found. 
//  If no invalid zero is found, the method will terminate after setting validZeroes to true
void ValidateZeroes() 
{
    //string[] address = ipv4Input.Split(".");
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}

//in this method, also updated code to use return.
void ValidateRange() 
{
    //string[] address = ipv4Input.Split(".");
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
*/
/* END OF UNIT 5 
////////////////////////////
Recap - learned
- Use Methods to quickly structure applications;
- The return keyword used to terminate method execution
- each method can be design to solve a step of a problem
- use methods to solve small problems to build up solution
*/
////////////////////////////////////////////////////
/////unit 6 of 9  
//Exercise - Complete the challenge to create a reusable method
//  create role-playing multiplayer game
//////////////////////////////////////////////////////////////////////
/////unit 6 of 9; unit 7 review solution...
//Exercise - Complete the challenge to create a reusable method (use Program.cs) re-worked on 2025/9/6
//
//Tell a fortune
//- develop a massive multiplayer role-playing game. 
//- Each player has a luck stat that can affect their odds of finding rare treasure. 
//- Each day, a player can speak to an in-game fortune teller that reveals whether their luck stat is high, low, or neutral.
//
//Created a tellFortune method that can be called at any time, 
//Replaced the existing logic with a call to your method.
//
///////////////////////////////
//Solution from unit 7 and here:
/// I did reviewed and it is using a method to display the fortune.
/// ran the project 
/// 2025/9/6 Added bonus is now all my project files are in one folder and just commited to GitHub
///  I will continue to learn and how to version of my code and commit again and push to GitHub today

/*
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
*/
////////////////END OF UNIT 7/////////////////////////////////
///UNIT 8: review questions and answered a quiz in freecodecamp progress
//////////////////////////////////////////////////////////