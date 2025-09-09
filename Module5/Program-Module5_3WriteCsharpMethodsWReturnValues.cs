////////////////////////////////////////////////////
//2025/1/24; 2025/2/1 Unit 5; reviewed 2025/2/22; 2025/9/6
//Module 5:  PART 3 - total 10 units - Create C# methods that return values
////////////////////////////////////////////////////
//Learning objectives:
//1. Understand return types
//2. Learn more about the return keyword
//3. Learn more about capturing method return values

//Introduction:
/*
Methods can provide return values after performing their tasks. 
By using parameters and return types together, you can create streamlined methods that 
receive input, perform a task, and provide output. This format allows you to efficiently 
build functionality into your programs while maintaining clean, readable code.

Suppose you need to create an application that uses many methods to perform calculations on input values. 
You need a way to retrieve the results of the calculations, and use those results throughout your program. 
You can do this by creating methods with return values.

Consider a game where the player must fight enemies. 
The game contains some code that determines if a character was hit whenever an Update() method is called. 
The code might contain the following methods:
*/

/*
Looking at the method signatures, you can imagine how the input and output 
of each method can be used across the program. The methods also make the game code more 
robust since each one has return values that can be used for different types of scenarios.

Capturing return values from methods is incredibly useful for all sorts of applications. 
In this module, you'll learn more about method execution and working with method return types.

// void Update();

// int[] GetEnemyCoordinates(string enemyId);
// int[] GetDistanceFromHero(string enemyId);
// int[] GetHeroCoordinates();

// bool EnemyCanHitHero(string enemyId);
// int GetEnemyDamageOutput(string enemyId);
// void UpdateHeroHP(int damage);
*/
//////////////////////////////////////////////
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
    //learned: always make sure passing in the parameter of a method expects the same data type
    total += GetDiscountedPrice(i);
}
total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

//learned: the return line of code also restults a double value, therefore valid and no errors
//note declaring in the beginning of this method expects returns double
double GetDiscountedPrice(int itemIndex)
{
     return items[itemIndex] * (1 - discounts[itemIndex]);
}

//learned: you return the result of the comparison that evaluates to a bool. 
//Returning expressions from methods is a great way to make your code organized and improve readability.
//note declaring in the beginning of this method expects returns boolean
bool TotalMeetsMinimum()
{
     return total >= minimumSpend;
}

//learned: When this method is called, evaluates input.ToString, 
//then evaluates and returns the substring value. 
//The flexibility of the return keyword allows you to create short lines of code packed with functionality.
//note declaring in the beginning of this method expects returns a string
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
} 
*/
//output:
//learned: first try, compilation keep failing, due to my previous work did not commented out and then run this
//error: line(56,1): error CS8802: Only one compilation unit can have top-level statements.
//
//Total: $44.58
/////////
//Recap
//1. Methods can return a value by specifying the return data type, or void for no return value
//2. The return keyword can be used with variables, literals, and expressions
//3. ** The value returned from a method must match the specified return type
//4. Data returned from methods can be captured and used by the caller of the method

////////////////////////////////////////////////////
///UNIT 3 of 10  -- Return numbers from methods
//1. create a method that returns an integer
//this code will convert USD to VND currency
/* double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");

//create this method: expects returns an integer, takes in a double parameter
//the return will cast the result to an integer
//if no cast in return result, you'll see the following error: Cannot implicitly convert type 'double' to 'int'.
int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
} */
//output:
//$23.73 USD = $557655 VND

//////////Another task - 2. create another method (VndToUsd)that returns a double
/* 
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
//output:
//$23.73 USD = $557655 VND
//$557655 VND = $23.73 USD //this one returns a double value
/////////////////////////////////////////////////////////////////
///UNIT 4 of 10 -- Return strings from methods
/*
//20250906 Lam: reviewed and this is a good common one..
Suppose you're a candidate in a coding interview. 
The interviewer asks you to write a method to reverse a string without using string.Reverse. 
Take a moment to think about how you might accomplish this task.
You might have decided that you can reverse a string by iterating from the end of the string. 
You can use a temporary string to store each letter from end to beginning. Let's get started!

string ReverseWord(string word) 
{
    string result = "";

    return result;
}

//iterate through the given word and update the result, update the above method...
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)   //the key logic is here, starts at the end of word, and i-- move backwords
    {
        result += word[i];
    }
    return result;
}
*/
//ran code:
//output: 
//snake
//ekans

//NOTE and reviewed again: When coding, it's important to frequently check your work. 
//- Finding and correcting mistakes early in the coding process allows you to spend more time 
//////////task 2 - Create a method to reverse words in a sentence
//this means on each word in a sentence, reverse each word
/* string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";

    //testing: what if it I dont split the words?
    //return result = ReverseWord(input);
    string[] words = input.Split(" ");  //split each word by space
    foreach(string word in words)  //loop and reverse each word
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
} */
// output 1: reverse each word in a sentence
//there are snakes at the zoo
//ereht era sekans ta eht ooz
// output 2: just reverse the entire sentence
// there are snakes at the zoo
// ooz eht ta sekans era ereht

//////////////////////////////////////////////////////
/////unit 5 of 10 - Return Booleans from methods
//////////////////////////////////////////////////////
//20250906 Lam: reviewed and this is a good common one..
//Description/Requirements:  
//Suppose you're a candidate in a coding interview. 
//The interviewer wants you to check if several words are a palindrome. ??
//What is a palindrome?  if a word can reads the same backwards and forwards. 
//For example, the word racecar is a palindrome. Let's get started!
/* 
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
//because string is a string array, use for loop is common to review each:
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

//declare method here that returns boolean, passing in a string
bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    //the key logic here: compare the first and the last letters of the word. 
    // If they match, then compare the second and the second-to-last letter of the word. 
    // if you reach the middle of the word, then all letters compare. 
    //if any letters don't match, the word in not palindrome, return false
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
//output:
// Is it a palindrome?
// racecar: True
// talented: False
// deified: True
// tent: False
// tenet: True

/////////////////////////////////////////////////////////
///Unit 6 of 10 - Return arrays from methods
//20250906 Lam: reviewed and treat this an important lesson
//when develop app, we often need to have methods to modify sets of data, performing operations on data,
//create arrays of data and keep code usable

//here's some of this task requirements: 
//- several coins of different values. 
//- find two coins whose sum is equal to a target value. 
//- coins available are represented in an integer array. 
//- return the indices of the two coins in a new array. Let's get started!
/*
guidance of one approach: 
1. Choose one number from the integer array
2. Check other numbers:  one at a time (for loop) to see if they add up to the target value
3. Return the result as soon as a match is found (method has return value)
*/
//this method TwoCoins() returns an integer array, takes in an integer array, and a target value:
// int[] TwoCoins(int[] coins, int target) 
// {
//     return new int[0];
// }
//To check each number in the array, update the TwoCoins method with the following:
//Error on first try on this example below did not complile:
//ERROR: error CS0161: 'TwoCoins(int[], int)': not all code paths return a value
/* 
//let come up any target value to be the sum of 2 coins:
int target = 60;
//first array consists of these available coin and their values
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
//result integer array calls the methods that passing in the coins values and the target to be evaluated
int[] result = TwoCoins(coins, target);
if (result.Length == 0) //check for length
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
    //LOGIC TO CHECK SUM OF 2 COINS FOR THE target value
    for (int curr = 0; curr < coins.Length; curr++)  //curr represents one fixed coin index 
    {
        for (int next = curr + 1; next < coins.Length; next++) //next represents the subsequent coin indices
        {
            if (coins[curr] + coins[next] == target) //check if sum of the values at curr and next are equal to the target value
            {
                return new int[] { curr, next }; //If the sum is equal, create an array to store those indices and return it. 
            }
        }
    }
    return  new int[0];  //by adding back this line to the code, fixed the error
}
 */
//Still error on 2025/9/6.
//Error on first try on this example below did not complile:
//ERROR: error CS0161: 'TwoCoins(int[], int)': not all code paths return a value
//Solution: added the line on line 330 in order to work
//supposed output:
//Change found at positions 2 and 5
/////////////////////////////////////
//SOLUTION below...
//fixed syntax within method to have a return value...
//also, the instructions now move on to use 2D array int[,]
/* 
int target = 30;
//int target = 80;
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
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
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
            //add this to prevent out of bounds error since count is added above when there is a matched target value 
            //and if matched larger than 5 pairs
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }

    //if (count == 0)
    //{
    //   return new int[0,0];  //note this is 2D array
    //}
    //return result;
    //further update: use this 1 line of code as a shorten to the other format
    return (count == 0) ? new int[0, 0] : result;
} */
//OUTPUT:
//1st try gets this:No two coins make change
//2nd run:
// 0,3
// 0,4
// 1,3
// 1,4
// 3,6
//output when updated target to 80:
// No two coins make change
//2025/9/6 Lam: rerun and review code
////////////////////////////////////////////////////
//2025/9/6  Module 5:  UNIT 7 of 10 Complete a challenge
////////////////////////////////////////////////////
//Requirements:
/*
dice mini-game - design a mini-game, 
select target number and random number (1 to 5)
player 1 roll a six-sided dice
to win: player roll a number > than target number
at end of game: offer player to play again, yes or no to continue or end application

//given some instructions and guidance
methods:
ShouldPlay: This method should retrieve user input and determine if the user wants to play again
WinOrLose: This method should determine if the player has won or lost
variables:
target: The random target number between 1 and 5
roll: The result of a random six-sided die roll
*/
//code:
/* 
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You Win!";
    }

    return "You Lose!";
} 
*/
//run code and output:
//NOTE has warnings but game is going on
// C:\Temp\CsharpProjects\TestProject\Module5\Program-Module5_3WriteCsharpMethodsWReturnValues.cs(438,23): warning CS8600: Converting null literal or possible null value to non-nullable type.
// C:\Temp\CsharpProjects\TestProject\Module5\Program-Module5_3WriteCsharpMethodsWReturnValues.cs(439,12): warning CS8602: Dereference of a possibly null reference.
// Would you like to play? (Y/N)
// n
// PS C:\Temp\CsharpProjects\TestProject> dotnet run
// Would you like to play? (Y/N)
// y
// Roll a number greater than 3 to win!
// You rolled a 5
// You Win!

// Play again? (Y/N)
// y
// Roll a number greater than 1 to win!
// You rolled a 4
// You Win!

// Play again? (Y/N)
// y
// Roll a number greater than 5 to win!
// You rolled a 3
// You Lose!

// Play again? (Y/N)
// n 
////////////////END OF UNIT ///////////
/// Next is guided project!
//////////////////////////////////////////////////////////