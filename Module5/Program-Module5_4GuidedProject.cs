////////////////////////////////////////////////////
//2025/2/22; 2025/9/6 reviewed and rerun and study each method...
//Module 5:  PART 4: total 8 units
////////////////////////////////////////////////////
/*
Learning objectives:
1. Plan design details with pseudo-code
2. Use methods to perform specific tasks
3. Create methods that accept require and optional parameters
4. Use values returned from methods

Project overview
Plan a Petting Zoo Visit
You're developing an application for the Contoso Petting Zoo that coordinates school visits. 
The Contoso Petting Zoo is home to 18 different species of animals. 
At the zoo, visiting students are assigned to groups, and each group has a set of animals assigned to it. 
After visiting their set of animals,  the students will rotate groups until they've seen all the animals at the petting zoo.
By default, the students are divided into 6 groups. 
However, there are some classes that have a small or large number of students, 
so the number of groups must be adjusted accordingly. The animals should also be randomly assigned to each group, 
so as to keep the experience unique.

DESIGN: 
//1. Exercise - Plan your code using methods -- pseudo-code
3 visiting schools: A, B, C. Each of the school has these groups respectively: 6 3 2
    A has 6 groups
    B has 3 groups
    C has 2 groups
in each school, create potential methods since we are achieving these tasks: 
    randomize animals,  (total 18 species)
    assign animals to correct number of groups 
    print school name A , B, C  
    print animal groups

using System;
//18 animals
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
// RandomizeAnimals();
// AssignGroup()    
Console.WriteLine("School A");
// PrintGroup(group);
// var group = AssignGroup();
// string[,] group = AssignGroup();
*/
/////////////////////////////////////////////////////////
//2. Exercise - Create a method to shuffle an array
//after many reviews and comments, now this is the final check:
/* using System;

//define all 18 species animals in the pettingZoo string array
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

//the below section is for testing in the middle of project:
//RandomizeAnimals();
//string[,] group = AssignGroup();
//Console.WriteLine("School A");
//PrintGroup(group);
//for testing in the middle of project:
// foreach(string animal in pettingZoo) 
// {
//     Console.WriteLine(animal);
// }

//what this does PlanSchoolVisits, this is for each school to be used and called
//Consider that you need to perform the same tasks for each school. 
//The differences would be the name of the school and the number of groups. 
//This is a perfect opportunity to use a method with those parameters.
//With this code, you're able to perform the same tasks for each school. 
//You also set groups to the default value of 6. Next, you'll update your method to use the input values.
void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

/////////////////////////////////////////////////////////////////
///Unit 4 of 8 Exercise - Create a method to shuffle an array
/// notes:
/// Shuffle an array: consider how you would swap the values of two variables, a and b.
//      If you immediately assign a = b, you'll lose the original value of a and 
//      end up with two variables equal to b. 
//      You need to use a temporary variable to store the value of a 
//      before you can overwrite it. Let's use this concept to begin your task.
/// //////////////////
/// goal: randomize animals
/// no input parameters since you'll use the existing global pettingZoo
/// In this step, you initialized a random object to help us generate a random number. 
/// And you initialized r to a random integer between 0 and the length of the pettingZoo array. 
/// This will ensure you don't go out of bounds of the array. 
/// You can apply this code to the entirety of the array to randomize all of the elements.
/// For loop: Now you cycle through each element in the array, select a random index, later expand to use the range (i, pettingZoo.Length) 
/// instead of just random.Next(pettingZoo.Length);
/// reason: Some elements don't get swapped at all, and some elements are swapped multiple times.
/// iterate through the for loop, you update the range of the randomly selected index to exclude values less than i. 
/// This is because indices at values less than i have already been swapped in previous iterations of the loop.
void RandomizeAnimals()
{
    Random random = new Random();

    //1. temo use i and r represent random indices in array
    //int i = 0;
    //int r = 1;
    //int r = random.Next(i, pettingZoo.Length);

    //loop through each petting zoo animal until all 18
    for (int i = 0; i < pettingZoo.Length; i++) // cycle through each 0 to 17 element in the pettingZoo array
    {
        //r variable is moved here to set as a random value instead of 1; 
        // select as a random index, from 0 to 18
        int r = random.Next(i, pettingZoo.Length);

        //using temp variable prevents from losing the original value of pettingZoo[i] after overwritten
        string temp = pettingZoo[i];    //current pettingZoo animal as temp
        pettingZoo[i] = pettingZoo[r];  //set random animal as current 
        pettingZoo[r] = temp;           //set temp to random animal result; conisderd shuffled 
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////
//Create this AssignGroup method, return a 2D string array and passing in optional variable called groups
//note: used [groups, pettingZoo.Length/groups] to define the array size
//groups represents the number of animal groups you want to create
//pettingZoo.Length/groups reflects how many animals are assigned to each group
//For example, since pettingZoo is a fixed array of 18 elements, the 2D array size for School A is [6,3]
//this method assigns the petting zoo animals to the designated number of groups
string[,] AssignGroup(int groups = 6) 
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;  //start is the starting position of pettingZoo
    //Using this start marker allows you to navigate through the pettingZoo array one element at a time even though the for-loops have different iterations
    for (int i = 0; i < groups; i++) //cycles through each grou
    {
        for (int j = 0; j < result.GetLength(1); j++) //cycles for the number of animals the go should contain
        {
            result[i, j] = pettingZoo[start++]; //assign animals
        }
    }
    return result;
}

///////////////////////////////////////////////////////
//Create method PrintGroup to fulfill the last task return nothing, take in group array 
// and has console write group number
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
} */

//run program to see what happens
// //output:
// School A
// Group 1: rabbits  alpacas  ponies  
// Group 2: goats  tortoises  macaws  
// Group 3: lemurs  capybaras  iguanas  
// Group 4: pigs  llamas  emus
// Group 5: ducks  geese  chickens
// Group 6: ostriches  kangaroos  sheep
// School B
// Group 1: capybaras  alpacas  chickens  rabbits  pigs  sheep
// Group 2: lemurs  tortoises  geese  ducks  ostriches  iguanas
// Group 3: kangaroos  llamas  ponies  goats  macaws  emus
// School C
// Group 1: capybaras  ducks  kangaroos  chickens  sheep  lemurs  iguanas  ponies  pigs
// Group 2: alpacas  macaws  rabbits  emus  geese  tortoises  llamas  goats  ostriches
//lesson learned:
//reviewed code
//know where and when to call which methods
//result has: School A has six groups, 
//School B has three groups, and 
//School C has two groups. The order of the animals should be randomized for each school.
//////////end of module assessment to check knowledge///////////
///////////////////END OF GUIDED PROJECT ///////////////////////////////