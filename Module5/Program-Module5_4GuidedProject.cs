////////////////////////////////////////////////////
//2025/2/22
//Module 5:  PART 4 Guided Project Completed 1040PM
//Plan a Petting Zoo Visit
////////////////////////////////////////////////////
/*
Demonstrate your ability to develop a console app that relies on methods with different parameters 
and return values to coordinate a visit to the petting zoo.

Learning objectives
Plan design details with pseudo-code
Use methods to perform specific tasks
Create methods that accept require and optional parameters
Use values returned from methods

Project overview
You're developing an application for the Contoso Petting Zoo that coordinates school visits. 
The Contoso Petting Zoo is home to 18 different species of animals. At the zoo, 
visiting students are assigned to groups, and each group has a set of animals assigned to it. After visiting their set of animals, 
the students will rotate groups until they've seen all the animals at the petting zoo.
By default, the students are divided into 6 groups. However, there are some classes that have a small or large number of students, 
so the number of groups must be adjusted accordingly. The animals should also be randomly assigned to each group, 
so as to keep the experience unique.
*/
//1. Exercise - Plan your code using methods -- pseudo-code
/*
using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups

// RandomizeAnimals();
// AssignGroup()    
Console.WriteLine("School A");
// PrintGroup(group);
// var group = AssignGroup();
// string[,] group = AssignGroup();
*/
//2. Exercise - Create a method to shuffle an array

/*
using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


RandomizeAnimals();
string[,] group = AssignGroup();
Console.WriteLine("School A");
PrintGroup(group);
*/
/*

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}
 
////////////////////////////////////////////
///Unit 4 of 8 Exercise - Create a method to shuffle an array
void RandomizeAnimals() 
{
Random random = new Random();

for (int i = 0; i < pettingZoo.Length; i++) 
{
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}
}

//Exercise - Create a method with an optional parameter
string[,] AssignGroup(int groups = 6) 
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;
    for (int i = 0; i < groups; i++) 
    {
            for (int j = 0; j < result.GetLength(1); j++) 
            {
                result[i,j] = pettingZoo[start++];
            }
        
    }
    return result;
}

//Exercise - Create a method to display the results
void PrintGroup(string[,] group) 
{
    for (int i = 0; i < group.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++) 
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}
*/
//////////////////////////////////////////////////////////