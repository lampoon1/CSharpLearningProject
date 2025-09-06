/////////////////////////////////////////////
//2024/11/21; 2024/12/1; final edit 2024/12/2
//Module 3: 
//Guided project - Develop conditional branching and looping structures in C# 
////////////////////////
/* GOAL:
The application you develop will:

Add predefined sample data to the pets array.
Iterate a "menu options and user selection" code block to establish the outer loop of your application.
Implement code branches corresponding to the user's menu selections.
Display all the information contained in the array used to store pet data (based on user's menu selection).
Iterate an "add new animal information" code block that enables the user to add one or more new animals to the pets array (based on user's menu selection).
By the end of this module, you will be able to develop code that combines selection and iteration statements to achieve your application design goals.
*/
/*Pre-req
Prerequisites
Experience using Visual Studio Code to develop, build, and run C# console applications that include console I/O and access methods of .NET classes.
Experience using C# code to evaluate conditional expressions and manage variable scope inside and outside of code blocks.
Experience using if-elseif-else and switch-case statements in C# to match a variable or expression against several possible outcomes.
Experience using foreach, for, do, and while statements in C# to loop through a block of code and access elements of array variables.
*/
//////////////////////
//Unit 2 of 8 - Prepare
/*
Project overview
You're working on the Contoso Pets application, an application that helps place pets in new homes. The specifications for your application are:
Create a C# console application.
Store application data in a multidimensional string array named ourAnimals.
The ourAnimals array includes the following "pet characteristics" for each animal:

Pet ID #.
Pet species (cat or dog).
Pet age (years).
A description of the pet's physical condition/characteristics.
A description of the pet's personality.
The pet's nickname.

*/
//////////////////////
//Unit 3 of 8
//Exercise - Build sample data and menu selection loops
//--Write switch statement for menu selections
//--Write placeholder code for each case of the switch statement
///////////////////////
//Unit 4 of 8
//Exercise - Write code to display all ourAnimals array data
//--Build a loop to iterate through the ourAnimals array
//--Check for existing pet data and display result
//--Display all pet characteristics for pets with data assigned
///////////////////////
//Unit 5 of 8
//Exercise - Build and test a loop for entering new pet data
//--Build a loop structure that will be used for entering new ourAnimals array data
/////////////////////////////
///Unit 6 of 8
//Exercise - Write code to read and save new ourAnimals array data
//--Build loop to read and validate the pet species
//--Build loop to read and validate the pet's age
//--Build loop to read and validate the pet's physical description
//--Build loop to read and validate the pet's personality description
//--Build loop to read and validate the pet's nickname
//done: 
//unit 7 is review questions, step/unit 8 is download a unit completed cert.
//////////////////////////////////////////////////////////
// the ourAnimals array will store the following: 

/*
using System;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement


//now convert if statement to switch statement
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;    
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;  
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    } 
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

//Console.WriteLine($"You selected menu option {menuSelection}.");
//Console.WriteLine("Press the Enter key to continue");

//// pause code execution
//readResult = Console.ReadLine();


switch(menuSelection)
{
    case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {                   
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;
        

    case "2":
        // Add a new animal friend to the ourAnimals array
        //Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        string anotherPet = "y";
        int petCount = 0;
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                petCount += 1;
            }
        }

        if (petCount < maxPets)
        {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        }
        
            
        while (anotherPet == "y" && petCount < maxPets)
        {
            bool validEntry = false;
            // get species (cat or dog) - string animalSpecies is a required field 
            do
            {
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalSpecies = readResult.ToLower();
                    if (animalSpecies != "dog" && animalSpecies != "cat")
                    {
                        validEntry = false;
                    }
                    else
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false);

            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

            // get the pet's age. can be ? at initial entry. 
            do
            {
                int petAge;
                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalAge = readResult;
                    if (animalAge != "?")
                    {
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                    else
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false);

            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
            do
            {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPhysicalDescription = readResult.ToLower();
                    if (animalPhysicalDescription == "")
                    {
                        animalPhysicalDescription = "tbd";
                    }
                }
            } while (animalPhysicalDescription == "");

            // get a description of the pet's personality - animalPersonalityDescription can be blank.
            do
            {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPersonalityDescription = readResult.ToLower();
                    if (animalPersonalityDescription == "")
                    {
                        animalPersonalityDescription = "tbd";
                    }
                }
            } while (animalPersonalityDescription == "");

            // get the pet's nickname. animalNickname can be blank.
            do
            {
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalNickname = readResult.ToLower();
                    if (animalNickname == "")
                    {
                        animalNickname = "tbd";
                    }
                }
            } while (animalNickname == "");

            // store the pet information in the ourAnimals array (zero based)
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
            petCount = petCount + 1;
        

            // check maxPet limit
            if (petCount < maxPets)
            {
                // another pet?
                Console.WriteLine("Do you want to enter info for another pet (y/n)");    
                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        anotherPet = readResult.ToLower();
                    }
                } while (anotherPet != "y" && anotherPet != "n");
            }
        }

        if (petCount >= maxPets)
        {
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();    
        }
        break;

    case "3":
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "4":
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "5":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();   
        break;

    case "6":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();   
        break;

    case "7":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();   
        break;

    case "8":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();   
        break;

    default:
        break;
}
*/