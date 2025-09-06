/////////////////////////////////////////////
//2024/11/17
//Module 3: Branch the Flow of Code Using the switch-case Construct in C#" module
////////////////////////
//Unit 2 of 6
//Exercise - Implement a switch statement
//unit 3 of 6
//Exercise - Complete a challenge activity using switch statements
/////////////////////////////////////////////////////
//exercise - Implement a switch statement
//example
/*
string fruit = "apple";
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
*/
/*
int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
Console.WriteLine($"{employeeName}, {title}");
*/
//Change the level variable value to see how the switch statement evaluates it
//Modify a switch section to include multiple labels

//////////////////////////////////////////////////////////////////////////
/////Challenge exercise: rewrite if-elseif-else using a switch statement
//////////////////////
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";


switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":    
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break; 
}

Console.WriteLine($"Product: {size} {color} {type}");
*/