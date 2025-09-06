////////////////////////////////////////////////////
//2025/1/24; 2025/9/6 (review and revision)
//Module 5:  PART 2 - total 9 units - Create C# methods with parameters
////////////////////////////////////////////////////
//Introduction
/*
Methods have the ability to perform operations on input. 
Passing parameters to your methods allows you to perform the method's task with different input values. 
Using method parameters lets you extend your code while keeping your program organized and readable. 
If you consider a method to be a black box that accepts input and performs a single task, 
you can quickly divide a large problem into workable pieces.
//
Suppose you need to write code that performs the same operation on different sets of input. 
You might have three different arrays, and need to display the contents of each one. 
You can create a DisplayArray method that accepts a single array as input and displays the contents. 
Instead of writing code to display each individual array, 
you can call the same method and provide the different arrays as input.
Parameters can make your methods more robust while still performing the same general task. 
In this module, you'll learn more about working with parameters and solidify your understanding of methods.
*/
//Objective:
/*
1. Learn more about using parameters
2. Understand method scope
3. Understand pass-by-reference and pass-by-value parameter types
4. Learn how to use optional and named arguments

prereq:
1. c# data types, int string arrays, 2D arrays, 
2. switch, if, for
3. Random class
4. methods
*/
/////////////////////////////////////////////////
/// unit 2 of 9 - use parameters in methods
/*
CountTo(5);

	void CountTo(int max) 
	{
		for (int i = 0; i < max; i++)
		{
			Console.Write($"{i}, ");
		}
	}
//ran the above section of code will display: 0, 1, 2, 3, 4, and then ends
*/

//continue to Create a method with parameters...
//this task I will create a method and accept a list of times and display new time zone
/*
int[] schedule = {800, 1200, 1600, 2000};

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
    int diff = 0;
    //int diff to store the time difference and then check to see that the provided GMT values are between -12 and 12. 
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) //Math.Abs gives you the absolute value of a number
    //GMT values are invalid if they're greater than 12.
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    //the hours difference is equal to the difference between the two numbers. 
    //If the GMT values have opposite signs, then the difference is equal to the sum of the two number
    //Since hours are represented in hundreds, you multiply the result by 100.
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    
    //to display results, do this:
    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

DisplayAdjustedTimes(schedule, 6, -6);
*/
// output with dotnet run
//800 -> 2000
//1200 -> 0
//1600 -> 400
//2000 -> 800
//////////////////////////////////////////////////////
/// //unit 3 of 9 - understand method scope
/// this one we will use for loop, if-else, each block of code has its own scope
/// scope is the region of a program where certain data is accessible
/// this pattern helps developers consistently using clearly named variables and easy to read code

//SHIFT + ALT + A will active block comment, try it...SUCCESS
/* 
//these are top-level statements, global variables 
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}
 */
 //observe output:
//Jenna, Ayesha, Carlos, Viktor,
//Robert, Vanya,
//note: parameter student takes precedence over the global student array

///////////
/// next exercise - understand method scope - circle info
/// first the declare if double pi was insde the method PrintCircleArea
/// then when it is used in PrintCircleCircumference, it has errors
/// the solution is to move the declare of pi variale be global variable.
/* 
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24); //yes i can be called twice

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    //double pi = 3.14159;
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
 */

////////////////////////////////////////////////////////
//RECAP
//1. Variables declared inside of a method are only accessible to that method.
//2. Variables declared in top-level statements are accessible throughout the program.
//3. Methods don't have access to variables defined within different methods.
//4. Methods can call other methods.

///////////////////////////////////////////
/// unit 4 of 9 -- use value and reference type parameters

//NOTE
//in c# variables has 2 main type: value an dreference types.
//value types such as int, double, bool, char, float, 
//referece types such as string, arrays, class, object (such as instances of Random class)

//reference type, but it is immutable - (once it has been assigned a value, it can't be altered)
//In C#, when methods and operators are used to modify a string, the result returned is a new string object.
/*
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}
//output:  
//(learned shortcut: Ctrl + / to comment out each line)
// inside Multiply method: 3 x 4 = 12
// global statement: 3 x 4 = 0
//the value of c is only altered within the Multiply method.
*/

/////////////next exercise - test with array
/*
int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);  //when clear is called, it modifies the original array
PrintArray(array);

void PrintArray(int[] array) 
{
    foreach (int a in array) 
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = 0;
    }
}
//output:
//1 2 3 4 5
//0 0 0 0 0
//the array remains altered outside of the Clear method scope. 
//This happens because the Clear method updated the values stored at each address
*/
/////////////Next exercise - test with string

/* //Test with strings
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
} */
//output:
// Start: Healthy
// Middle: Unhealthy
// End: Healthy
//If the SetHealth method didn't output the status, you might have assumed the method didn't execute correctly. 
//Instead, a new string with the value "Unhealthy" was created and then lost in the method scope.
//To correct this problem, you can change SetHealth to use the global status variable instead.
/* 
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
} */
//output:
// Start: Healthy
// Middle: Unhealthy
// End: Unhealthy
//Now the updated string is captured and stored correctly. 

///////////////////////////////
//RECAP
//1. Variables can be categorized as value types and reference types.
//2. Value types directly contain values, and reference types store the address of the value.
//3. Methods using value type arguments create their own copy of the values.
//4. Methods that perform changes on an array parameter affect the original input array.
//5. String is an immutable reference type.
//6. Methods that perform changes on a string parameter don't affect the original string.

/////////////////////////////////////////
//UNIT 5 of 9 Exercise - Methods with optional parameters
//Create an RSVP application
// in this task: create an application for guests to RSVP to an event.
//guests provide party sice, any allergies
//add option to restrict RSVPs to an invite-only guest list
//code:
/*
In this code, you check to see if the given name is equal to any of the names on the guest list. 
If a match is found, you set found to true and break out of the foreach loop. 
If found is false, you display a message and use the return keyword to terminate the method.
*/
/* 
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;
RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
//RSVP("Linh", 2, "none", false);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
//RSVP("Tony", 1, "Jackfruit", true);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}  */
//output:
// Sorry, Tony is not on the guest list

// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit


//improving further on the readability with named arguments
//When calling a method that accepts many parameters, 
//it can be tricky to understand what the arguments represent. 
//Using named arguments can improve the readability of your code. 
//Use a named argument by specifying the parameter name followed by the argument value. 

//exmaple
//using these line at the above code, compile and run it yields the samve result...
//RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
//also using this following line is vali since not all arguments are named:
//RSVP("Linh", 2, allergies: "none", inviteOnly: false); RSVP("Linh", partySize: 2, "none", false);
//now try this
//RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
//////
//NOTE same output, no errors:
// Sorry, Tony is not on the guest list

// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit

/////////////////another task
//Declare Optional parameters:
//1. To define optional parameters, update the RSVP method signature as follows:
//void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
//2. In each method call, notice that the name is never omitted. 
//When a method is called, all required arguments must always be included. 
//However, any optional arguments can be omitted.
//In this code, you removed the arguments 1, "none", true from Rebecca's rsvp. 
//Since these arguments match the default value, the result of Rebecca's rsvp is the same.
//
//You removed the inviteOnly argument from Nadia's rsvp. 
//Since the default value of inviteOnly is true, the result of Nadia's rsvp is the same.
//
//You removed the partySize argument from Tony's rsvp. If Tony had an invitation, 
//he default value of partySize would be used in the RSVP.
//
//You removed the allergies argument from both Linh and Noor's rsvps. 
//Their rsvps will display the default value of none for "Allergies".
/* 
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
 */
//NOTE: ran and produced the same output as before
// Sorry, Tony is not on the guest list

// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit
//In each method call, notice that the name is never omitted. 
//When a method is called, all required arguments must always be included. However, any optional arguments can be omitted.
//in the above code, name needs to always there, others are optional due to it has default values if not given

///////////////////////////
//RECAP
//** Parameters are made optional by setting a default value in the method signature.
//** Named arguments are specified with the parameter name, followed by a colon and the argument value.
//** When combining named and positional arguments, you must use the correct order of parameters.

/////////////////////////////////////////////////////////////////
//UNIT 6 of 9 -- challenge exercise to display email addresses
//UNIT 7 of 9 -- review solution
//////////////////////////////////////////////////
//Add a method to display email addresses based on the previous exercises
//instructions:
/*
1. create a method that displays the correct email address for both internal and external employees. 
2. given lists of internal and external employee names. 
   An employee's email address consists of their username and company domain name.
   The username format is the first two characters of the employee first name, 
   followed by their last name. 
   Employee named "Robert Bavin" would have the username "robavin".  The domain for internal employees is "contoso.com".
*/

/*
Update the code to use a method to display the email addresses according to the challenge specifications.
Use what you've learned about using parameters and optional arguments to complete the update.
Verify that your code produces the following output:
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
*/

//code:
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    //call the Displayemail method and passing in first and last name, do not provide 3rd parameter since there is a default
    //value for coporate domain 
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);

}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    //call the Displayemail method and passing in all first, last name and domain since these are external folks
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

//in this method, first and last are required, and domain is optional, if not provide, give it the corporate value
void DisplayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}
//output: [clean code methods above]
// robavin@contoso.com
// sibright@contoso.com
// kisinclair@contoso.com
// aakamath@contoso.com
// sadelucchi@contoso.com
// siali@contoso.com
// viashton@hayworth.com
// codysart@hayworth.com
// shlawrence@hayworth.com
// davaldes@hayworth.com
//////////////////////////////////////////////////////////
//unit 8 knowledge check
//2025/9/6 time to commit to Git - tried in in the convenient source control screen on the left in VS Code
////////////////  END OF UNIT /////////////////////////////////
