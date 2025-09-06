/////////////////////////////////////////////
//2024/12/22; 2025/1/22
//Module 4: Work with variable data in C# Console Applications
//PART 6 - Guided Project - Work with variale data in C#
////////////////////////
//Unit 1 of 7
//////////////////////
/*
Learning objectives
-Apply iteration statements to gather data input.
-Use data processing.
-Format data output.
-Choose the correct data types and safely convert data types.
-Manipulate number, string and character arrays, as well as add, remove, and sort data.
-Modify and build complex strings from multiple data sources, and format data for display across regions.
//////////////////////////////
Project background:
Suppose you're a developer who likes to support the local community. 
You and some of your friends started a business that helps find new homes for stray or abandoned cats and dogs. 
Your business started off small, with just a couple of animals, but it's starting to grow. 
Your friends have an initial application developed that enables the entry and display of the animals available for adoption. 
They ask you to investigate adding features to the app that could help to match the animals in your care with 
people who are looking for a new family pet.

You begin with a starting application that adds a predefined sample data to the pets array. The application has two menu items. 
The first item displays all the pet data, and the code is complete. The second is menu item, 
"Display all dogs with a specified characteristic", is "work in progress" that you complete.

You also make updates to existing code to add suggestedDonation data and display all data in a shortened format.

By the end of this module, you're able to develop code that combines iteration 
statements with data input, data processing, string indexing, and data output.
*/
//////////////////////////////////////////////////
//Unit 2 of 7
//Prep:
/*
The design specification
For the new features of the Contoso Pets application, the design specification provides details for the dog search and suggested donation features:

Dog attribute search
-Gather input for the pet characteristic search term
-Loop through the animals array and identify "dogs"
-For each dog, combine the physical and personality descriptions to search
-Search the combined description for the input term match
-Output the dogs that have a term match

Suggested donation data
-Define suggestedDonation string
-Expand the ourAnimals array to contain suggestedDonation and populate sample data for suggestedDonation
-Ensure all usage of ourAnimals array accounts for the added suggestedDonation data
-Output suggestedDonation with regional currency symbol ($, €, ¥,... )
*/

//desire output:
//1. List all of our current pet information
//2. Display all dogs with a specified characteristic
//Enter menu item selection or type "Exit" to exit the program
//GOAL:
//1. update the existing code to develop app features described previously. The key features:
//      Add dog attribute search
//      Include suggested donation data
////////////////////////////////
///Unit 3 of 7; 4 of 7; 5 of 7;  -- 2025/1/22 
///
///Task 1 of 3: Add dog attribute search. In this task, you add the dog attribute search feature to the Contoso Pets application.
///Task 2 of 3: Include suggested donation data. Update the existing code to include the suggested donation data   
///Task 3 of 3: Add dog search
//

/*
// #1 the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";


// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;
        
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "N/A";
            animalPersonalityDescription = "N/A";
            animalNickname = "lion";
            suggestedDonation = "45.00";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    //ourAnimals[i, 6] = "Suggested Donation: "  + suggestedDonation;

    //
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// #5 display the top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Display all dogs with a specified characteristic
            string dogCharacteristic = "";

            while (dogCharacteristic == "")
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                }
            }
            string dogDescription = "";
            bool noMatchesDog = true;
            // #6 loop through the ourAnimals array to search for matching animals
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1].Contains("dog"))
                    {
                        // #7 Search combined descriptions and report results
                        dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                        if (dogDescription.Contains(dogCharacteristic))
                        {
                            Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                            Console.WriteLine(dogDescription);

                            noMatchesDog = false;
                        }
                    }
                }
            if (noMatchesDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            }     
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
*/
////////////////////END OF PROJECT/////////////////////////