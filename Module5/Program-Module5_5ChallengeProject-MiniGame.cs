////////////////////////////////////////////////////
//2025/2/22
//Module 5:  PART 5 Challenge Project -- Create a mini-game
//
////////////////////////////////////////////////////
/*
Creating your own game is an exciting way to practice your programming skills. Games rely heavily on processing user input 
to make dynamic decisions. Every game must also have a set of defined rules that determine actions and events in the game.

Suppose you want to create your own game. You might not be ready to develop a fully featured game, 
so you decide to start as small as possible. You want to move a character across the screen and make it consume an object. 
The object consume can affect the state of the player. 
To keep the game going, you wanted to regenerate the object in a new location once it has been consumed. 
You decide that you'll need to use methods to keep your game code organized.

In this module, you'll develop the following features of a mini-game application:

A feature to determine if the player consumed the food
A feature that updates player status depending on the food consumed
A feature that pauses movement speed depending on the food consumed
A feature to regenerate food in a new location
An option to terminate the game if an unsupported character is pressed
A feature to terminate the game if the Terminal window was resized
By the end of this module, you'll create a playable mini-game application!
*/

//Project Sepecification:
/*
- The code declares the following variables:
    - Variables to determine the size of the Terminal window.
    - Variables to track the locations of the player and food.
    - Arrays `states` and `foods` to provide available player and food appearances
    - Variables to track the current player and food appearance

- The code provides the following methods:
    - A method to determine if the Terminal window was resized.
    - A method to display a random food appearance at a random location.
    - A method that changes the player appearance to match the food consumed.
    - A method that temporarily freezes the player movement.
    - A method that moves the player according to directional input.
    - A method that sets up the initial game state.

- The code doesn't call the methods correctly to make the game playable. The following features are missing:
    - Code to determine if the player has consumed the food displayed.
    - Code to determine if the food consumed should freeze player movement.
    - Code to determine if the food consumed should increase player movement.
    - Code to increase movement speed.
    - Code to redisplay the food after it's consumed by the player.
    - Code to terminate execution if an unsupported key is entered.
    - Code to terminate execution if the terminal was resized.
*/
//UNIT 3 of 7
// using System;

// Random random = new Random();
// Console.CursorVisible = false;
// int height = Console.WindowHeight - 1;
// int width = Console.WindowWidth - 5;
// bool shouldExit = false;

// // Console position of the player
// int playerX = 0;
// int playerY = 0;

// // Console position of the food
// int foodX = 0;
// int foodY = 0;

// // Available player and food strings
// string[] states = {"('-')", "(^-^)", "(X_X)"};
// string[] foods = {"@@@@@", "$$$$$", "#####"};

// // Current player string displayed in the Console
// string player = states[0];

// // Index of the current food
// int food = 0;

// InitializeGame();
// while (!shouldExit) 
// {
//     //Move();
//     if (TerminalResized()) 
//     {
//         Console.Clear();
//         Console.Write("Console was resized. Program exiting.");
//         shouldExit = true;
//     } 
//     else 
//     {
//         if (PlayerIsFaster()) 
//         {
//             Move(1, false);
//         } 
//         else if (PlayerIsSick()) 
//         {
//             FreezePlayer();
//         } else 
//         {
//             Move(otherKeysExit: false);
//         }
//         if (GotFood())
//         {
//             ChangePlayer();
//             ShowFood();
//         }
//     }
// }

// // Returns true if the Terminal was resized 
// bool TerminalResized() 
// {
//     return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
// }

// // Displays random food at a random location
// void ShowFood() 
// {
//     // Update food to a random index
//     food = random.Next(0, foods.Length);

//     // Update food position to a random location
//     foodX = random.Next(0, width - player.Length);
//     foodY = random.Next(0, height - 1);

//     // Display the food at the location
//     Console.SetCursorPosition(foodX, foodY);
//     Console.Write(foods[food]);
// }

// // Returns true if the player location matches the food location
// bool GotFood() 
// {
//     return playerY == foodY && playerX == foodX;
// }

// // Returns true if the player appearance represents a sick state
// bool PlayerIsSick() 
// {
//     return player.Equals(states[2]);
// }

// // Returns true if the player appearance represents a fast state
// bool PlayerIsFaster() 
// {
//     return player.Equals(states[1]);
// }
// // Changes the player to match the food consumed
// void ChangePlayer() 
// {
//     player = states[food];
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Temporarily stops the player from moving
// void FreezePlayer() 
// {
//     System.Threading.Thread.Sleep(1000);
//     player = states[0];
// }

// // Reads directional input from the Console and moves the player
// void Move(int speed = 1, bool otherKeysExit = false) 
// {
//     int lastX = playerX;
//     int lastY = playerY;
    
//     switch (Console.ReadKey(true).Key) 
//     {
//         case ConsoleKey.UpArrow:
//             playerY--; 
//             break;
// 		case ConsoleKey.DownArrow: 
//             playerY++; 
//             break;
// 		case ConsoleKey.LeftArrow:  
//             playerX--; 
//             break;
// 		case ConsoleKey.RightArrow: 
//             playerX++; 
//             break;
// 		case ConsoleKey.Escape:     
//             shouldExit = true; 
//             break;
//         default:
//             // Exit if any other keys are pressed
//             shouldExit = otherKeysExit;
//             break;    
//     }

//     // Clear the characters at the previous position
//     Console.SetCursorPosition(lastX, lastY);
//     for (int i = 0; i < player.Length; i++) 
//     {
//         Console.Write(" ");
//     }

//     // Keep player position within the bounds of the Terminal window
//     playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
//     playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

//     // Draw the player at the new location
//     Console.SetCursorPosition(playerX, playerY);
//     Console.Write(player);
// }

// // Clears the console, displays the food and player
// void InitializeGame() 
// {
//     Console.Clear();
//     ShowFood();
//     Console.SetCursorPosition(0, 0);
//     Console.Write(player);
// }

//Make player consumes food
//display message: Console was resized. Program exiting.
//UNIT 5 of 7 - Next unit: Exercise - Add code to modify movement

/*
You also want to add an optional feature that detects if the player appearance is (^-^) and if so, increase or decrease the right and left movement speeds by a value of 3 while that appearance is active. When the player state is ('-'), you want the speed to return to normal. You want to make this feature optional since consuming food in this state requires more collision detection than you want to develop for now.

Check if the player should freeze
Create a method that checks if the current player appearance is (X_X)
The method should return a value
Before allowing the user to move the character, call your method to determine the following:
Whether or not to use the existing method that freezes character movement
Make sure the character is only frozen temporarily and the player can still move afterwards

Add an option to increase player speed
Modify the existing Move method to support an optional movement speed parameter
Use the parameter to increase or decrease right and left movement speed by 3
Create a method that checks if the current player appearance is (^-^)
The method should return a value
Call your method to determine if Move should use the movement speed parameter
*/
//
//////////////////////////////////////////////////////////