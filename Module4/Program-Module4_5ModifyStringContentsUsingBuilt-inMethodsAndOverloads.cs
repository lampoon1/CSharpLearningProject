/////////////////////////////////////////////
//2024/12/12; 2024/12/22
//Module 4: Work with variable data in C# Console Applications
//PART 5 - Modify the content of strings using built-in string data type methods
////////////////////////
//Unit 1 of 8
//////////////////////
/*
Learning objectives
-Identify the position of a character or string inside of another string
-Extract portions of strings
-Remove portions of strings
-Replace values in strings with different values

In this module, you use string helper methods to identify and isolate the information you're interested in. 
You learn how to copy a smaller portion of a larger string. You replace characters, or remove characters from a string.

By the end of this module, you're able to modify a string's contents, 
isolating specific portions to extract, replace, or remove.
*/
//////////////////////////////////////////////////
//Unit 2 of 8
//Exercise - Use the string's IndexOf() and Substring() helper methods
////////////////////////////////////////////
//CODE:
/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
13
36 */
/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
//output: (inside the parentheses
*/

//modify the starting position of the sub string...
/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
//output: 
//inside the parentheses */

//another round:
/* string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
//output: 
//between the tags */
///////////////////////////
/////from experienct and tips:
///Avoid magic values
//Hardcoded strings like "<span>" in the previous code listing are known as "magic strings" 
//and hardcoded numeric values like 6 are known as "magic numbers". 
//These "Magic" values are undesirable for many reasons and you should try to avoid them if possible.
//The compiler doesn't catch "<sapn>" at compile time because the value is in a string. 
//The misspelling leads to problems at run time, and depending on the complexity of your code, it might be difficult to track down.
//Furthermore, if you change the string "<span>" to the shorter "<div>", 
//but forget to change the number 6 to 5, then your code produces undesirable results.

//another round of coding:
/* string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
//same output as previous, updated the logic be less problematic. 
*/

///////////////////////////////////////
/*  Recap
- IndexOf() gives you the first position of a character or string inside of another string.
- IndexOf() returns -1 if it can't find a match.
- Substring() returns just the specified portion of a string, using a starting position and optional length.
- There's often more than one way to solve a problem. You used two separate techniques to find all instances of a given character or string.
- Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.
*/
//=======================
//UNIT 3 of 8 -- continue on 2024/12/22
/////////////////////////////////
// Exercise - Use the string's IndexOf() and LastIndexOf() helper methods
/* string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
//output:
//For the message: 'hello there!', the first 'h' is at position 0 and the last 'h' is at position 7. */

//another code:
/* string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

//openingPosition += 1;  //output: set of parentheses
//openingPosition += 0; //output: (set of parentheses
openingPosition += 3;  //output: t of parentheses
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); 

//output:
//set of parentheses
//explanation:
//The key to this example is the use of LastIndexOf(), which you use to get the positions of the last opening and closing parentheses. 
*/

//retrieve all isntances of a substrings inside parantheses
//start code here:
/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

//output:
//What if
//more than
//set of parentheses
//explanation:
//take a minute to look at this last line: message = message.Substring(closingPosition + 1);
//  This line is a bit tricky. It's a common pattern in C# to update a variable with a new value. 
//  When you use Substring() without specifying a length input parameter, it will return every character after the 
//  starting position you specify. With the string being processed, message = "(What if) there are (more than) one (set of parentheses)?"
//take a minute to look at these 2 lines: 
//int openingPosition = message.IndexOf('(');
//if (openingPosition == -1) break;
//The IndexOf() method returns -1 if it can't find the input parameter in the string. You merely check for the value -1 and break out of the loop.
*/

//Work with different types of symbol sets with IndexOfAny()
//start code here:
/*
string message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
*/
//output:
//Found 'e' in 'Hello, world!' at index: 1.
//Now try to update the string and add different symbols such as [] {} to search for
//mulitple symbols at the same time, use IndexOfAny() method.
//update code to:
/* 
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
*/
//OUTPUT:
//Searching THIS message: Help (find) the {opening symbols}
//Found WITHOUT using startPosition: (find) the {opening symbols}
//Found WITH using startPosition 5:  (find) the {opening symbols}
//explanation:
//You used .IndexOfAny() without, and then with, the starting position overload.

//Next: 
//Now that you found an opening symbol, you need to find its matching closing symbol.
/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/
//OUTPUT:
//What if
//different symbols
//open symbol
//matching closing symbol
//explanation:
//1. read the comments that help explain the code.
//2. examining the code and locate the following line of code using IndexOf() to define closingPosition:
//      closingPosition = message.IndexOf(matchingSymbol, openingPosition);
//variable closingPosition is used to find the length passed into the Substring() method, and to find the next openingPosition value:
//      int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//For this reason, the closingPosition variable is defined outside of the while loop scope and initialized to 0 for the first iteration.

//Recap
//Here are two important things to remember:
//LastIndexOf() returns the last position of a character or string inside of another string.
//IndexOfAny() returns the first position of an array of char that occurs inside of another string.
///////////////////////////////
///
/// Unit 4 of 8  -- 2024/12/22
///Exercise - Use the Remove() and Replace() methods
///
//1
//starts code here:
/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
//OUTPUT:
//123455000  3
//explanation:
//this method works like the Substring method, supply a start position and the length to remove teh characters from the string.
//starts at postion 5 and removes 20 characters.
*/

//2
//starts code to use Replace() method:
/*
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/
//output:
//This is example data
//explanation:
//  used the Replace() method twice. The first time you replaced the string -- with a space. 
//  The second time you replaced the string - with an empty string, which completely removed the character from the string.

//Recap
//Here are two important things to remember:
//The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
//The Replace() method swaps all instances of a string with a new string.

//////////////////////////////
//unit 5 of 8
//Exercise - Complete a challenge to extract, replace, and remove data from an input string
//////////////////////////
//start code here with some starter code:
/*
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

//get quantity and display
int quantityStart = input.IndexOf(openSpan) + openSpan.Length; //+length of <span> 
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

//set output to input, replace trademark symbol with registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

//remove opening and closing div tags
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);;

const string closeDiv = "</div>";
int divEnd = output.IndexOf(closeDiv);
//get output and display
output = $"Output: " + output.Remove(divEnd, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
*/
//Notice the tags:<div>,<h2>,<span> and symbol code &trade; contained in the input variable.
//desired output:
//Quantity: 5000
//Output: <h2>Widgets &reg;</h2><span>5000</span>
//next, modify code above to get the desired output.
//The updated code output when project compiled and run:
//Quantity: 5000
//Output: <h2>Widgets &reg;</h2><span>5000</span>
//explanation:
//This code is merely "one possible solution." As long as your code produces the following output, you were successful.
//////////////////////////
/////end of module 4. Last step is quiz and certification. COMPLETED at 11:49PM, 12/22/2024.
////////////////////////////////