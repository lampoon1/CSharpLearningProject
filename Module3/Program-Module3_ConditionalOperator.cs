/////////////////////////////////////////////
//2024/11/11
//New Module: Add logic to C# console applications (Get started with C#, Part 3)  
//Evaluate Boolean expressions to make decisions in C# 
////////////////////////
//Unit 3 of 9
///Exercise - Implement the conditional operator
/////////////////////////////////////////////////////
//What is the conditional operator?
//The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on 
//whether the Boolean expression evaluates to true or false. The conditional operator is commonly 
//referred to as the ternary conditional operator.
//////////////////////////////////////////////////////////////////////
//basic form:
//<evaluate this condition> ? 
//<if condition is true, return this value> : 
//<if condition is false, return this value>
///////////////////////////////////////////////////////////////////////
//Scenario for the coding exercise below:
//Take a minute to consider how you'd apply the conditional operator to the promotional discount scenario. 
//Your goal is to display a message to the customer that shows their discount percentage. 
//The amount of their discount will be based on whether they've spent more than 1000 euros on their purchase.
///////////////////////////////
//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

//now use the conditional check in the console writeline and save one variable creation:
//int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
/////////////////////////////////////////////////////////////////////////
/*
Recap
You should remember the following facts about the conditional operator:

You can use the conditional operator to reduce the size of your code, 
but you should ensure that the resulting code is easily readable.
You can use the conditional operator when you need to return a value 
that's based on a binary condition. 
Your code will return the first option when the condition evaluates to true, 
and it will return the second option when the condition evaluates to false.
*/
//1.  implement a conditional operator to simulate a "coin flip". The resulting decision logic will display either heads or tails.
//use Random class
/*
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
*/

//or use this simplified version:
//Random coin = new Random();
//Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
//////////////////////////////////////////////////////////////////////
/*

//string permission = "Admin|Manager";
//int level = 55;
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/
/////////////////////////////////////////////////////////////////////////
