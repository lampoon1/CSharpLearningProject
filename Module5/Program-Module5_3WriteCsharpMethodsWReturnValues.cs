////////////////////////////////////////////////////
//2025/1/24; 2025/2/1 Unit 5; reviewed 2025/2/22
//Module 5:  PART 3 - total 10 units - Create C# methods that return values
////////////////////////////////////////////////////
/*
Learning objectives:
Understand return types
Learn more about the return keyword
Learn more about capturing method return values
*/
//Introduction:
/*
Methods can provide return values after performing their tasks. 
By using parameters and return types together, you can create streamlined methods that 
receive input, perform a task, and provide output. This format allows you to efficiently 
build functionality into your programs while maintaining clean, readable code.
Suppose you need to create an application that uses many methods to perform calculations on input values. Y
ou need a way to retrieve the results of the calculations, a
nd use those results throughout your program. 
You can do this by creating methods with return values.

Consider a game where the player must fight enemies. 
The game contains some code that determines if a character was hit whenever an Update() method is called. 
The code might contain the following methods:
*/
/*Looking at the method signatures, you can imagine how the input and output 
of each method can be used across the program. The methods also make the game code more 
robust since each one has return values that can be used for different types of scenarios.

Capturing return values from methods is incredibly useful for all sorts of applications. 
In this module, you'll learn more about method execution and working with method return types.

void Update();

int[] GetEnemyCoordinates(string enemyId);
int[] GetDistanceFromHero(string enemyId);
int[] GetHeroCoordinates();

bool EnemyCanHitHero(string enemyId);
int GetEnemyDamageOutput(string enemyId);
void UpdateHeroHP(int damage);
*/
///////////////////////////////////
///UNIT 2: Understand return type syntax
//1. Using void as the return type means the method only performs operations and doesn't return a value. 
//void PrintMessage(string message)
//2. Use methods to calculate the total purchase price
//The Contoso Shopping Center is having a super sale! Many items have discounted price. 
//You're given a list of item prices and a list of corresponding discounts. 
//The discounts are represented by percentages, for example 50% = 0.5. 
//If a customer spends more than 30.00, they receives 5.00 of their total purchase. 
//In this task, you'll write code to calculate the customer's total.
/*
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}
total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
     return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
     return total >= minimumSpend;
}

string FormatDecimal(double input)
{
     return input.ToString().Substring(0, 5);
}
*/
/* Recap
Here's what you've learned about the return keyword so far:

Methods can return a value by specifying the return data type, or void for no return value
The return keyword can be used with variables, literals, and expressions
The value returned from a method must match the specified return type
Data returned from methods can be captured and used by the caller of the method
*/
/////////////////////////////////////////////////
///UNIT 3 of 10  -- Return numbers from methods
//1. create a method that returns an integer
/*
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}
*/
/*
//2. create a method that returns a double
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}
*/
//////////////////////////////////////
///UNIT 4 of 10 -- Return strings from methods
/*
Suppose you're a candidate in a coding interview. 
The interviewer asks you to write a method to reverse a string without using string.Reverse. 
Take a moment to think about how you might accomplish this task.
You might have decided that you can reverse a string by iterating from the end of the string. 
You can use a temporary string to store each letter from end to beginning. Let's get started!
*/
/*
string ReverseWord(string word) 
{
    string result = "";

    return result;
}
*/
/*
Create a method to reverse words in a sentence
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
/*
When coding, it's important to frequently check your work. 
Finding and correcting mistakes early in the coding process allows you to spend more time 
building upon correct code rather than debugging one large program. 
Checking your work frequently is a skill that coding interviewers value highly as well.
*/
/*
Create a method to reverse words in a sentence
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");  
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
*/
/////////////////////////////////////////
/////unit 5 of 10 - Return Booleans from methods
//Description/REquirements:  Suppose you're a candidate in a coding interview. 
//The interviewer wants you to check if several words are a palindrome. 
//A word is a palindrome if it reads the same backwards and forwards. 
//For example, the word racecar is a palindrome. Let's get started!
/*
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
} 
*/
////////////////////////////////////////
///Unit 6 of 10 - Return arrays from methods
//Description/Requirements: Suppose you have several coins of different values. 
//You're tasked to find two coins whose sum is equal to a target value. 
//In this exercise, the coins available are represented in an integer array. 
//You'll need to return the indices of the two coins in a new array. Let's get started!
//
//There are many approaches to solve this problem. 
//Take a moment to consider how you might search for two numbers in an array whose sum is equal to a given value.
/*
In this exercise, the following approach will be used:
Choose one number from the array
Check other numbers one at a time to see if they add up to the target value
Return the result as soon as a match is found
*/
//Example below did not complile:
//ERROR: error CS0161: 'TwoCoins(int[], int)': not all code paths return a value

//int[] TwoCoins(int[] coins, int target) 
//{
//    return  new int[0];
//}
//To check each number in the array, update the TwoCoins method with the following:
/*
int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target) 
{
    //ADD LOGIC TO CHECK SUM OF 2 COINS FOR THE target value
    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                return new int[]{curr, next};
            }

        }
    }
}
*/
//Find multiple pairs of coins that make change
//Example below did not complile:
//ERROR: error CS0161: 'TwoCoins(int[], int)': not all code paths return a value
//fixed syntax within method to have a return value...
/*
//int target = 30;
int target = 80;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);
if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
            

        }
    }
    return (count == 0) ? new int[0,0] : result;
}
*/


////////////////END OF UNIT /////////////////////////////////
//////////////////////////////////////////////////////////