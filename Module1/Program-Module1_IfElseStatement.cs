// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////////////////////////////////////////////////
//Random dice = new Random();
//int roll = dice.Next(1, 7);
//Console.WriteLine(roll);
////////////////////////////////////////////////

////////////////////////////////////////////////
//This following example will generate error: obj ref is required for non-static field.
//Random dice = new();
//int result = Random.Next();
////////////////////////////////////////////////

////////////////////////////////////////////////
/* Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}"); */
////////////////////////////////////////////////

////////////////////////////////////////////////
/*
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/
////////////////////////////////////////////////

////////////////////////////////////////////////
//Unit 2 of 7 
//Write code that generates three random numbers and displays them in output
//unit 3 of 7
//Use if and else statements instead of two separate if statements
//Use if, else, and else if statements to give a prize instead of a win-lose message
/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {    
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    } 
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/
////////////////////////////////////////////////
///
////////////////////////////////////////////////
//Unit 4 of 7 
//Exercise - Complete a challenge activity to apply business rules
/*
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//discountPercentage = random.Next(0, 11);
Console.WriteLine($"daysUntilExpiration: {daysUntilExpiration}");
//Console.WriteLine($"discountPercentage: {discountPercentage}");

if (daysUntilExpiration == 0) 
{
    Console.WriteLine($"Your subscription has expired.");
    
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day.");
    //Console.WriteLine($"Renew now and save 20%!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <=5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    //Console.WriteLine($"Renew now and save 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration <=10)
{
   Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
*/