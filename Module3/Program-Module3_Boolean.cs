/////////////////////////////////////////////
//2024/11/11
//New Module: Add logic to C# console applications (Get started with C#, Part 3)  
//Evaluate Boolean expressions to make decisions in C# 
////////////////////////
//Unit 2 of 9
//////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////
//Use the equality operator:
/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
*/
/////////////////////////////////////////////////////////////////////
//Improve the check for string equality using the string's built-in helper methods
/*
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());  //returns True
*/
////////////////////////////////////////////////////////////////////////////////////////////
///Use the inequality operator
/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/
///////////////////////////////////////////////////////////////////////////////////////
//Evaluate the Comparison operators
/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/
/////////////////////////////////////////////////////////////
///Methods that return a Boolean value
/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
*/
////////////////////////////////////////////////////////////
///Use the Logical Negation operator
/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/
////////////////////////////////////////////////////////////////
//Inequality operator versus logical negation
/*int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
*/
////////////////////////
///RECAP

/*

Here's the main takeaways you learned about evaluating Boolean expressions so far:

There are many different kinds of expressions that evaluate to either true or false.
Evaluate equality using the == operator.
Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
Evaluate inequality using the != operator.
Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
If a method returns a bool, it can be used as a Boolean expression.
Use the logical negation operator ! to evaluate the opposite of a given expression.
*/
/////////////////////////////////////////////////////////////////////////////////