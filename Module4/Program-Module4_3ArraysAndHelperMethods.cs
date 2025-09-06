/////////////////////////////////////////////
//2024/12/4 
//Module 4: Work with variable data in C# Console Applications
//PART 3  - Perform operations on arrays using helper methods in C#
////////////////////////
/*
Prerequisites
Introductory level experience with arrays
Introductory level experience with the if statement
Introductory level experience with built-in methods on data types (like string)
Experience using Visual Studio Code to develop, build, and run C# code
*/
//////////////////////
//Unit 1 of 10
//////////////////////
//Objectives:
/*
Sort and reverse the order of array elements.
Clear and resize the elements of an array.
Split a string into an array of strings or characters (chars).
Join array elements into a string.
*/
//////////////////////
///Unit 2 of 10
/////////////////////////
///Exercise - Discover Sort() and Reverse()
/////////////////////////////////////////////////////////////////////////////
///
/////start code here...
//1. create an array of pallets then sort them:
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
//2. Reverse the order of the pallets
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
//////////////////////
///Unit 3 of 10
//Exercise - Explore Clear() and Resize()
//Use array methods to clear and resize an array
//////////////////////
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
//Access the value of a cleared element
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
//Call a string helper method on a cleared element (Sting.ToLower())
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
//Resize the array to add more elements - focus on this line: Array.Resize(ref pallets, 6);
//this is resizing the pallets array from four elements to 6. 
//The new elements are added at the end of the current elements. The two new elements are null until you assign a value to them.
string[] pallets =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
//OUTPUT:
/*
Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13

Resizing 6 ... count: 6
-- 
-- 
-- B12
-- A13
-- C01
-- C02
*/


//Resize the array to remove elements
//Conversely, you can remove array elements using Array.Resize().
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
//OUTPUT
/* 
Clearing 2 ... count: 4
--
--
-- B12
-- A13

Resizing 6 ... count: 6
--
--
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
--
--
-- B12
*/

/* Extra:
Can you remove null elements from an array?Can you remove null elements from an array?
If the Array.Resize() method doesn't remove empty elements from an array, 
is there another helper method that does the job automatically? 
No. The best way to empty elements from an array would be to count 
the number of non-null elements by iterating through each item and increment a variable (a counter). 
Next, you would create a second array that is the size of the counter variable. 
Finally, you would loop through each element in the original array and copy non-null values into the new array.

Recap
Here's a few important ideas that you covered in this unit:

Use the Clear() method to empty the values out of elements in the array.
Use the Resize() method to change the number of elements in the array, removing or adding elements from the end of the array.
New array elements and cleared elements are null, meaning they don't point to a value in memory.
*/

////////////////////////
///Unit 4 of 10
////////////////////////
///Exercise - Discover Split() and Join()
/////String data type's Array methods: Use the ToCharArray() to reverse a string
//string value = "abc123";
//char[] valueArray = value.ToCharArray();

//Reverse, then combine the char array into a new string
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
*/
///OUTPUT:
///321cba

//The expression new string(valueArray) creates a new empty instance of the System.String class 
//(which is the same as the string data type in C#) and passes in the char array as a constructor.
//out of scope for now for the learning of System.STring class related to the string data type and constructor

//Combine all of the chars into a new comma-separated-value string using Join()
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);
*/
//OUTPUT:
//3,2,1,c,b,a

//Split() the comma-separated-value string into an array of strings
//This method is designed for variables of type string and creates an array of strings.
//focus on line string[] items = result.Split(',');
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/
//OUTPUT:
/*
3,2,1,c,b,a
3
2
1
c
b
a
*/
/////////////////////
//Unit 5 of 10; 6 of 10
////////////////////
//Exercise - Complete a challenge to reverse words in a sentence
//write code to reverse each word in a message.
//string pangram = "The quick brown fox jumps over the lazy dog"; 
//OUTPUT:
//ehT kciuq nworb xof spmuj revo eht yzal god

//NOTE: this is just one of many ways to approach this program:
//1. create first string array called message, split it
//2. create a second message array stores a reverse copy of the first message string array
//3. for each element in 2nd new message array, reverse it, store the result back into 2nd message array
//4. join the reverse message array as one line of string result, add a space to it, display by writeline the new string result
/*
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
*/
//OUTPUT:
//ehT kciuq nworb xof spmuj revo eht yzal god

/////////////////////////////
///UNIT 7 of 10; 8 of 10
////////////////////////////
//Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
//parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.
//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//output: 
/*
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/

//1 of many solution:
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//parse the individual "Order IDs", 
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        //display item if exactly 4 characters long in length
        Console.WriteLine(item);
    }
    else
    {
        //tagged as "Error" if they are not exactly four characters in length.
        Console.WriteLine(item + "\t- Error");
    }
}
*/
//OUTPUT::
/*
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/

// 9 of 10 review and completion
//////////////////////////////////////////////////