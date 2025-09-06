/////////////////////////////////////////////
//2024/11/17; 11/19
//Module 3: Add looping logic to your code using the do-while and while statements in C#
////////////////////////
//Unit 2 of 8
//Exercise - Create do and while iteration loops
//unit 3 of 8
//Exercise - Complete a challenge activity using do and while iteration statements
//Role playing game battle challenge
///////////////
//output:
//////////////
//Monster was damaged and lost 1 health and now has 9 health.
//Hero was damaged and lost 1 health and now has 9 health.
//Monster was damaged and lost 7 health and now has 2 health.
//Hero was damaged and lost 6 health and now has 3 health.
//Monster was damaged and lost 9 health and now has -7 health.
//Hero wins!

//unit 5 of 8 
//Exercise - Complete a challenge activity to differentiate between do and while iteration statements
/////////////////////////////////////////////////////
//1. do-while syntax
/*
do
{
    // This code executes at least one time
} while (true);
*/

//Write a do-while statement to break when a certain random number is generated
/*
Random random = new Random();
int current = 0;
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
//////////////////
///Write a while statement that iterates only while a random number is greater than some value
/////2. Use the continue statement to step directly to the Boolean expression
/*Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/
/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//Use the continue statement to step directly to the Boolean expression -- see above update.
//NOTE: I use this line and the code will not stop running: while (current != 11);

////////////////////////////////////////////////////////////////////////////////////
///exercise: Complete a challenge activity using do and while iteration statements
///////////////////////////////
///Role playing game battle challenge
///Code challenge - write code to implement the game rules
/* Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.

output:
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/

/* My try: */
/*
Random random = new Random();
int hero = 10;
int monster = 10;
int attack = random.Next(1, 11);
int winlose = random.Next(0, 2);

Console.WriteLine(attack);
do
{
    if (winlose == 1) 
    {
        Console.WriteLine("hero wins");
        monster = monster - 1;
        Console.WriteLine($"{hero}, {monster} ");
    }
    else
    {
        Console.WriteLine("monster wins hero lost");
        hero = hero - 1;
        Console.WriteLine($"{hero}, {monster} ");
    }

    Console.WriteLine(attack);
} while (hero <= 0  || monster <=0 );
*/
//suggested  answer:
/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/
/*
Examine the difference between do and while statement iterations
As you have seen, C# supports four types of iteration statements: for, foreach, do-while, and while. Microsoft's language reference documentation describes these statements as follows:

The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
The do-while statement: conditionally executes its body one or more times.
The while statement: conditionally executes its body zero or more times.
*/
/////////////////////////////////////////////////////////////////////////////
/////unit 5 of 8 
//Exercise - Complete a challenge activity to differentiate between do and while iteration statements
/////////////////////////////////////////////////////
////1
/*
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
*/

/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }

} while (validEntry == false);
*/

/*
// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
*/

//////////////////////////////////////
///Code project 1 - write code that validates integer input
///Code project 2 - write code that validates string input
///Code project 3 - Write code that processes the contents of a string array
/////string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
/////
/* OUTPUT 1 */
/*
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/
/* OUTPUT 2:
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/
/* OUTPUT 3:
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/

/* Project 1 Solution and working! */
/*
string? readResult;
string valueEntered = "";
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numericValue);

    if (validNumber == true)
    {
        if (numericValue <=5 || numericValue >= 10)
        {
            validNumber = false; 
            Console.WriteLine($"You entered {numericValue},  not within required range, please try again.");   
        }
    }
    else 
    { 
        //validNumber = true; 
        Console.WriteLine("Enter invalid number, please try again.");        
    }
} while (validNumber == false);
Console.WriteLine($"Your input accepted and value:  {numericValue}");
readResult = Console.ReadLine();
*/