/////////////////////////////////////////////
//2024/11/11
//Exercise - Get started with array basics
//unit 2 of 7
//
/////////////////////////////////////////////
/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
*/

/*
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

///////////////////////////////////////////
//unit 3 of 7
//Exercise - Implement the foreach statement

/*
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/
/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}
Console.WriteLine($"We have {sum} items in inventory.");
*/

//Create a variable to hold the current bin number and display the running total
/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

//results:
//Bin 1 = 200 items (Running total: 200)
//Bin 2 = 450 items (Running total: 650)
//Bin 3 = 700 items (Running total: 1350)
//Bin 4 = 175 items (Running total: 1525)
//Bin 5 = 250 items (Running total: 1775)
//We have 1775 items in inventory.
*/

/////////////////////////////////////////////
//unit 4 of 7
//Exercise - Complete a challenge activity for nested iteration and selection statements
/*
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
*/