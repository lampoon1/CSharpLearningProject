////////////////////////////////////////////////////
//2025/3/25; 2025/9/6 
//Module 6:  2 Implement the Visual Studio Code debugging tools for C#
//12 units
////////////////////////////////////////////////////
//Unit 1. 
//Implement the Visual Studio Code debugging tools for C#

/*
Learn how to effectively debug C# programs in Visual Studio Code 
using breakpoints and the other debugging tools, such as resources in the RUN AND DEBUG view.

Learning objectives
1. Configure the Visual Studio Code debugger for a C# program.
2. Create breakpoints and step through your code to isolate issues.
3. Inspect your program state at any execution step.
4. Use the call stack to find the source of an exception.

////////////////////////////////////////////////////
//Unit 2
Examine the Visual Studio Code debugger interface
1. Configure and launch the debugger: The Run menu and RUN AND DEBUG view can both be used to configure and launch debug sessions.
2. Examine application state: The RUN AND DEBUG view includes a robust interface that exposes various aspects of your application 
state during a debug session.
3. Runtime execution control: The Debug toolbar provides high-level runtime controls during code execution.

steps I took to get familiar in VS Code
Go to Run Menu, learn all the drop down options: 
Start debugging F5
Open configurations
Step Over  F10
Step Into  F11
Step Out   Shift+F11
Continue   F5
Toggle Breakpoint F9
and more...

Run and Debug view user interface:
know the Run and Debug control Panel: VARIABLES, WATCH, CALL STACK , BREAKPOINTS sections
know where debug tool bar on the top middle, and know current execution step
know the DEBUG CONSOLE that display messages

//////////////
Recap
1. The Visual Studio Code user interface can be used to configure, start, and manage debug sessions. 
2. The launch.json file contains the launch configurations for your application.
3. The Run menu provides easy access to common run and debug commands grouped into six sections.
4. The RUN AND DEBUG view provides access to runtime tools, including the Run and Debug controls panel. 
5. The sections of the RUN AND DEBUG view are VARIABLES, WATCH, CALL STACK, and BREAKPOINTS.
6. The Debug toolbar provides execution controls while your application is running such as pause/continue, 
step over, step into, step out, restart and stop.
7. The DEBUG CONSOLE is used to display messages from the debugger. The DEBUG CONSOLE can also display console 
output from your application.
*/

//=======================================================================
//unit 3  2025/9/6 SAT it's been a day of review and now back to last learning mindset
//Exercise - Run code in the debug environment
////////////////////////////////////////////////////////
/*
//so VS Code app has user interface enables developers to run their code in a debug environment
//it uses the .NET Core runtime to launch and interact with an application
//another long-winded explanation...
When you start the debugger, it creates a new instance of the runtime and runs the application within that instance. 
The runtime includes an application programming interface (API), 
which the debugger uses to attach to the running process (your application).

Once your application is running and the debugger is attached, 
the debugger communicates with the running process using the .NET Core runtime's debugging APIs 
and a standard debug protocol. The debugger can interact with the process 
(the application running within the .NET runtime instance) by setting breakpoints, 
stepping through code, and inspecting variables. Visual Studio Code's debugger interface enables you 
to navigate the source code, view call stacks, and evaluate expressions.

The most common way to specify a debug session is a launch configuration in the launch.json file. 
This approach is the default option enabled by the debugger tools. 
For example, if you create a C# console application and select Start Debugging from the Run menu, 
the debugger uses this approach to launch, attach to, and then interact with your application.
*/

//Create a new code project
//I did it as instructions says do it on desktop\Debug101
//then I cut and paste whole project back to c:\temp\CsharpProjects\TestProject\Debug101_VSCodeProject
//
//NOTES to learn new things:
//open Program.cs will create its .sln file
//.sln file is a solution file that is used by Visual Studio to manager project and is usually created auto
//when you creat a new project in VS Code. 
//The .sln file is used by debugger to identify the project that should be run in the debug environment.
//some errors and not finding launch.json or .vscode folder when create this new Debug101 project
//need to re-try next day
//need a break

//////RECAP
/// /////////////
/// 
/// Here are a few important things to remember from this unit:

// The Visual Studio Code debugger for C# uses the .NET Core runtime to launch and interact with an application.
// The Visual Studio Code Run menu has options to start an application with and without the debugger attached.
// The Debug toolbar includes a button to Stop a running process.
// The RUN AND DEBUG view includes an option to start debugging an application.
///////////////////////////////////////////////////////////////////
/// Unit 4 of 12 -- Examine breakpoint configuration options
/// possibly cannot do it until I figure out how to start the debugger on this file or the new project Program.cs file
/// 
/// tasks to do: set breakpoints
/// remove, disable, and enable breakpoints
/// conditional breakpoints
/// support for Hit Count breakpoints and Logpoints
/// RECAP
/// //////////////
//1. Visual Studio Code enables setting breakpoints in the code editor or from the Run menu. 
//      Breakpoint code lines are marked with a red dot to the left of the line number.
//2. Breakpoints can be removed or disabled using the same options used to set them. 
//      Bulk operations that affect all breakpoints are available on the Run menu.
//3. Conditional breakpoints can be used to pause execution when a specified condition is met 
//      or when a 'hit count' is reached.
//4. Logpoints can be used to log information to the terminal without pausing execution or inserting code.
/////////////////////////////////////////////////////////////////////////
/// Unit 5 of 12 -- Set breakpoints 
/// 1. set breakpoint to the line number in project code
/// 2. learn Step Into, Step Out
/// modify code and verify in debug mode
/// merge 2 lines 
//    else if (name == "AllGreetings")
//       messageText = SophiaMessage() + "\n\r" + AndrewMessage();
/// Run, STart debugging
/////////////////////////////////////////////////////////////////////////
/// Unit 6 of 12 -- Examine launch of configurations file
///launch.json file
/*
Attributes of a launch configuration
The launch.json file includes one or more launch configurations in the configurations list. 
The launch configurations use attributes to support different debugging scenarios. 
The following attributes are mandatory for every launch configuration:

name: The reader-friendly name assigned to the launch configuration.
type: The type of debugger to use for the launch configuration.
request: The request type of the launch configuration.
preLaunchTask: specifies a task to run before debugging your program. Th
program: set to the path of the application dll or .NET Core host executable to launch.

This property normally takes the form: ${workspaceFolder}/bin/Debug/<target-framework>/<project-name.dll>.

Where:

<target-framework> is the framework that the debug project is being built for. 
This value is normally found in the project file as the 'TargetFramework' property.
<project-name.dll> is the name of debugged project's build output dll. 
This property is normally the same as the project file name but with a '.dll' extension.
For example: ${workspaceFolder}/bin/Debug/net7.0/Debug101.dll

Note

The .dll extension indicates that this file is a dynamic link library (dll) file. I
f your project is named Debug101, a file named Debug101.dll is created when a build task compiles 
your program using the Program.cs and Debug101.csproj files. 
You can find the Debug101.dll file in the EXPLORER view by expanding the "bin" and "Debug" folders, 
and then opening a folder that represents the .NET framework used by your code project, 
such as "net7.0". The .NET Framework version is specified in your .csproj file.

Cwd
The cwd attribute specifies the working directory of the target process.
Args
The args attribute specifies the arguments that are passed to your program at launch. There are no arguments by default.    
Console
The console attribute specifies the type of console that's used when the application is launched.
 The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole.

//====================
Exercise: to do: 
Update the launch configuration to accommodate console input
To edit the console attribute:

Open the launch.json file in the Visual Studio Code Editor.

Locate the console attribute.

Select the colon and assigned value, and then enter a colon character.

Notice that when you overwrite the existing information with a colon, 
Visual Studio Code IntelliSense displays the three options in a dropdown list.
Select either integratedTerminal or externalTerminal.

Save the launch.json file.

//exercise todo
Next: you can update the launch configuration to accommodate multiple applications
Notice that the .vscode folder containing the launch.json and tasks.json files is associated with the workspace folder, 
SpecialProjects, not the individual project folders.

*/
/// The following example shows how you could configure the launch.json file 
/// to include configurations for both the "Project123" and "Project456" applications.
/// 
/*
"version": "0.2.0",
"configurations": [
    {
        "name": "Launch Project123",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "buildProject123",
        "program": "${workspaceFolder}/Project123/bin/Debug/net7.0/Project123.dll",
        "args": [],
        "cwd": "${workspaceFolder}/Project123",
        "console": "internalConsole",
        "stopAtEntry": false
    },
    {
        "name": "Launch Project456",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "buildProject456",
        "program": "${workspaceFolder}/Project456/bin/Debug/net7.0/Project456.dll",
        "args": [],
        "cwd": "${workspaceFolder}/Project456",
        "console": "internalConsole",
        "stopAtEntry": false
    }
]
*/
///The following example shows how you could configure the tasks.json file. 
/// In this case, the named tasks specify build operations that are specific to the "Project123" and "Project456" applications. 
/// The build task ensures that any saved edits are compiled and represented in the corresponding .dll file that's attached to the debugger. 
/*
"version": "2.0.0",
"tasks": [
    {
        "label": "buildProject123",
        "command": "dotnet",
        "type": "process",
        "args": [
            "build",
            "${workspaceFolder}/Project123/Project123.csproj",
            "/property:GenerateFullPaths=true",
            "/consoleloggerparameters:NoSummary"
        ],
        "problemMatcher": "$msCompile"
    },
    {
        "label": "buildProject456",
        "command": "dotnet",
        "type": "process",
        "args": [
            "build",
            "${workspaceFolder}/Project456/Project456.csproj",
            "/property:GenerateFullPaths=true",
            "/consoleloggerparameters:NoSummary"
        ],
        "problemMatcher": "$msCompile"
    }
]
*/
/// Recap
//Here are two important things to remember from this unit:

//Launch configurations are used to specify attributes such as name, type, request, preLaunchTask, program, and console.
//Developers can edit a launch configuration to accommodate project requirements.
///////////////////////////////////////////
/// //unit 7 of 12
///  Configure conditional breakpoints in C#
/////////////////////////////////////////////////
/*
Note
Visual Studio Code also supports a conditional breakpoint that triggers based on the number of times the breakpoint has been "hit".

exercise: Use a standard breakpoint to examine a data processing application
Replace the contents of your Program.cs file with the following code:
*/

/*
int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i);

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true) ;

static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1, 10000) + 10000;
        int num2 = rand.Next(1, 101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i, 1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i, 1] = "new";
            prodID = prodID + "-n";
        }
        else
        {
            products[i, 1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i, 0] = prodID;
    }
}

static string Process1(string[,] products, int item)
{
    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

    return products[item, 1];
}

static string Process2(string[,] products, int item)
{
    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
    if (products[item, 1] == "new")
        Process3(products, item);

    return "continue";
}

static void Process3(string[,] products, int item)
{
    Console.WriteLine($"Process3 message - processing product information for 'new' product");
}


 */
//Configure a conditional breakpoint using an expression
/*
Right-click your existing breakpoint, and then select Edit Breakpoint.

Enter the following expression:
products[i,1] == "new";

Notice that the expression is no longer displayed after you press Enter.

To display the expression temporarily, hover the mouse pointer over the breakpoint (red dot).

To run your application with the conditional breakpoint configured, select Start Debugging.

Wait for the application to pause at the conditional breakpoint.

Notice the value of i displayed under the VARIABLES section.

On the Debug controls toolbar, select Continue

Notice that the value of i has been updated the VARIABLES section.

Select Step Into.

Continue selecting Step Into until the Process1 message is displayed.

Notice that Process1 reports that it's working on a new product.

Take a moment to consider the advantage that conditional breakpoints offer.

In this simulated data processing scenario, there is about a 1% chance that a product is new.
 If you're using a standard breakpoint to debug the issue, you'd need to walk through the analysis of 
 about 100 products to find one of the new products that you're interested in.

Conditional breakpoints can save you lots of time when you're debugging an application.

Use the Stop button to stop code execution.
Congratulations! You successfully configured a conditional breakpoint.
*/
//////////
//Recap
////////
//Here are two important things to remember from this unit:

//Use a standard breakpoint to pause an application each time a breakpoint is encountered.
//Use a conditional breakpoint to pause an application when a Boolean expression evaluates to true.

///////////////////////////////////////////////////////////////////
///unit 8 -  Monitor variables and execution flow
////////////////////////////////////////////////////
/*
The RUN AND DEBUG view provides developers with an easy way to monitor variables and expressions, 
observe execution flow, and manage breakpoints during the debug process.

Examine the sections of the Run and Debug view
Each section of the RUN AND DEBUG view provides unique capabilities. Using a combination of these sections 
during the debug process is often helpful.

VARIABLES section
Monitoring variable state is an important aspect of code debugging. Unexpected changes in variable state
 will often help to identify logic errors in your code.

The VARIABLES section organizes your variables by scope. The Locals scope displays the variables in the current scope (the current method).
Note

The top-level statements section of a console application is considered its own method. A method named Main.

You can unfold (expand) the displayed scopes by selecting the arrow to the left of the scope name. 
You can also unfold variables and objects. The following screenshot shows the numbers array unfolded under the Locals scope.
WATCH section
CALL STACK section
useful
Exception has occurred: CLR/System.DivideByZeroException
An unhandled exception of type 'System.DivideByZeroException' occurred in Debug1.dll: 'Attempted to divide by zero.'
    at Program.<<Main>$>g__WriteMessage|0_1() in C:\Users\howdc\Desktop\Debug1\Program.cs:line 27
    at Program.<<Main>$>g__Process1|0_0() in C:\Users\howdc\Desktop\Debug1\Program.cs:line 16
    at Program.<Main>$(String[] args) in C:\Users\howdc\Desktop\Debug1\Program.cs:line 10

BREAKPOINTS section

to-do Exercise: Configure your application and launch configuration
When you're working on a console application that reads user input, you'll probably need to update launch configuration file

1. update program.cs
*/
/*
string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
*/
/*
Notice the following:

The code specifies an integer array containing five numbers.
The code displays output in the console.
The code prompts the user to enter a starting element number n that it uses to sum array elements n through 5.
The code calculates the sum in a method, displays the results in the console, and then pauses.

Note

The DEBUG CONSOLE panel does not support user input from the console.

On the Visual Studio Code File menu, select Save.

On the Run menu, select Remove All Breakpoints.

This removes any breakpoints left over from the previous exercise.

On the RUN AND DEBUG view, select Start Debugging.

Notice that an error occurs when the Console.Clear(); code line is executed.

On the Debug toolbar, select Stop.

Switch to the EXPLORER view, and then open the launch.json file in the Editor.

Update the value of the console attribute as follows:
JSON code
"console":"integratedTerminal",

On the Visual Studio Code File menu, select Save, and then close the launch.json file.
*/
//to-do exercise: Review application output and identify issues
/*
Switch back to the RUN AND DEBUG view.

On the RUN AND DEBUG view, select Start Debugging.

The messages displayed to the DEBUG CONSOLE panel show the debugger attaching to the Debug101.dll application.

Notice that no error messages are displayed.

Changing the value of the console attribute from internalConsole to integratedTerminal in the launch 
configuration file has fixed the console error. But now you need to locate the console that contains your output.

In the Panels area below the Editor, switch from the DEBUG CONSOLE panel to the TERMINAL panel.

Notice that code execution has paused at the message prompting the user to enter a value for n.

The output on the TERMINAL panel should look like the following:
The 'numbers' array contains: { 1 2 3 4 5 }

To sum values 'n' through 5, enter a value for 'n':

At the TERMINAL command prompt, enter 3

Review the output from the application.

The output on the TERMINAL panel should look like the following:
The 'numbers' array contains: { 1 2 3 4 5 }

To sum values 'n' through 5, enter a value for 'n':
3

The sum of numbers 3 through 5 is: 9
press Enter to exit

Take a minute to consider the reported value of sum and the values of array elements 3 through 5 displayed at the top of the console.

The message says: The sum of numbers 3 through 5 is: 9. However, array elements 3 through 5 are 3, 4, and 5. Shouldn't the reported sum be 12?

You can use the VARIABLES section of the RUN AND DEBUG view to investigate the issue.
*/
//////////////////////////
//Monitor variable state
/// 
/// //exercise
/*
Set a breakpoint on the following code line:
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

On the RUN AND DEBUG view, select Start Debugging.

Switch from the DEBUG CONSOLE panel to the TERMINAL panel.

At the TERMINAL command prompt, enter 3

Code execution will pause at the breakpoint.

Take a minute to review the VARIABLES section of the RUN AND DEBUG view.

Notice that startIndex has been assigned the value that you entered, which is 3.

Select Step Into.

Notice that the VARIABLES and CALL STACK sections are updated.

The CALL STACK section shows that code execution has moved into the SumValues method.

The VARIABLES section, which lists the local variables, shows the value of the integer n. 
The method parameter n is assigned its value from the method call argument startIndex. 
In this case, the change to variable names makes it clear the value has been passed, not a reference pointer.

Note

In this case, you can see most of your code in the Editor, so you might not need the CALL STACK section, 
but when you're working on larger applications with deeply nested and interconnected method calls, 
the execution path shown in the CALL STACK section can be extremely useful.

Continue selecting Step Into until the value assigned to sum is no longer 0.

Take a minute to review the information shown in the VARIABLES section.

You should see the following: Notice that the value assigned to sum went from 0 to 4.
To expand the numbers array, select numbers [int[]].

Recall that array elements are accessed using zero-based index numbers.

In this case, the logic error is a discrepancy between the instructions in the user interface and the underlying code. 
The user interface refers to array items 1-5. However, 
the code uses the value entered by the user to access the zero-based array elements. 
The array element that has an index of 3 stores a value of 4. The code doesn't compensate for zero-based index numbers.

To terminate the debug session, select Stop.

Take a minute to consider how you might fix the issue.

This issue could be corrected in the user interface by prompting the user to enter a value between 0 and 4. 
It could also be corrected in code by subtracting 1 from the value that's entered. 
Generally speaking, your goal should be a clear and easy to follow user interface. 
In this case it might be better to update the code as follows:
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

Running the updated code will produce the following output:
Update your code using the suggested approach, and then save your Program.cs file.

Clear your breakpoint, rerun the application in the debugger, and verify that the intended result is displayed in the TERMINAL.

You've just used variable state to identify and fix a logic issue! Great job.
*/
/////////////////////////////////
/// Monitor watch expressions
/*
The WATCH section can be used to monitor expressions that are based on one or more variables.

Suppose you're working on an application that performs numeric calculations on a data set. 
You believe that your code produces unreliable results when the ratio between two numeric variables is greater than 5. 
You can use the WATCH section to monitor the calculated ratio.

Update Program.cs as follow:
*/

/*
bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);

} while (exit == false);

*/
/*
Save your Program.cs file.

Set a breakpoint on the final code line.

Set the following WATCH expression: num2 / num1 > 5
On the RUN AND DEBUG view, select Start Debugging.

Notice the values displayed in the VARIABLES and WATCH sections.

Select Continue until you see the WATCH expression evaluate to true.

If the WATCH expression evaluated to true on the first iteration, select Continue a few more times or until you see true a second time.

Take a minute to consider how the WATCH section is being used.

In this scenario, you determined that your code produces unreliable results when the ratio between 
two numeric variables is greater than 5. You constructed an expression in the WATCH section that represents this condition. 
You can now use the WATCH section to track that condition.

*/
////////////////////////////////////////////////////////////////
///Modify the value assigned to a variable in the VARIABLES section
/*

There may be times when you want to create a programmatic condition manually. The VARIABLES section of the RUN AND DEBUG view enables you to do this by changing the state of a variable at runtime.

Take a minute to review the code that you're running.

Notice that the code will never exit out of the do loop because exit will never be true. 
This isn't a programmatic condition that you'ld need to alter in a real-world application, 
but it demonstrates the capability.

In the VARIABLES section, right-click exit [bool], and then select Set Value.

The VARIABLES section enables you to change the value assigned to a variable at runtime. 
This can be useful when you want to see how your code reacts to a particular condition.

To set the value of exit to true, type true and then press Enter.

In this case, changing the value of exit to true will cause the application to close when the while statement is executed.

Select Continue.
Notice that the DEBUG CONSOLE panel displays a message informing you that the program has exited.

Congratulations! You've successfully used the VARIABLES and WATCH sections of the RUN AND DEBUG view.
*/

////Recap
//Here are a few important things to remember from this unit:

//Monitor variable state using the VARIABLES section of the RUN AND DEBUG view.
//Track an expression across time or different methods using the WATCH section of the RUN AND DEBUG view.
//Use the CALL STACK section of the RUN AND DEBUG view to find the source location of an exception or a WATCH expression.
//Use the VARIABLES section to change a variable's assigned value at runtime.
//
//
///////////////////////////////////////////////////////////////////
///Unit 9 -  Challenge activity -- Complete a challenge activity using the debugger
////////////////////////////////////////////
//Variable state Challenge - 
//code sample that isn't producing the expected result. 
//You need to use breakpoints and the VARIABLES section of the RUN AND DEBUG view to help you figure out the issues.


/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
/*
int x = 5;

ChangeValue(x);

Console.WriteLine(x);

void ChangeValue(int value) 
{
    value = 10;
}
*/
/*
The code comment describes the desired functionality.

Run the application in the Visual Studio Code debugger.

Check the output produced.

Use the C# debugger tools to isolate the issue.

Consider how you might update the code to match the desired functionality.
*/
//////////////////////////
//Unit 10 -- see how to tackle this
//Review the solution for the code debugger challenge
////////////////////////////////////////////////////////
//1. Implement the C# debugger tools to identify the issue
//The following debug process implements a breakpoint and then monitors the value of x 
//      in the VARIABLES section of RUN AND DEBUG view.

//Set a breakpoint on the following code line:  int x = 5;
/*
Open the RUN AND DEBUG view.

At the top of the RUN AND DEBUG view, select Start Debugging.

In the VARIABLES section of the Run and Debug view, make note of the value assigned to x.

On the Debug control toolbar, select Step Into.

Track the value assigned to x as you step through each code line.

Notice that the value of x doesn't change as execution enters and exits the ChangeValue method.

The ChangeValue method is passed the value of x, rather than a reference to x, 
so the change to value inside the method doesn't affect the original variable x.

Consider a code update based on debugging results
If you want the ChangeValue method to change the value in the calling code, 
you need to update your code. 
One way to achieve your intended result would be to update the ChangeValue method to return an integer value, 
and update the code that calls ChangeValue so that it assigns the return value to x.

For example:
*/
/*
int x = 5;
x = ChangeValue(x);
Console.WriteLine(x);

int ChangeValue(int value) 
{
    value = 10;
    return value;
}
*/ 
//If you succeeded in this challenge, congratulations! Continue on to the knowledge check in the next unit.
//Completed knowledge check
///////////////////////////////////
/// Unit 12 of 12 summary
/*
Summary
Your goal was to gain experience debugging C# applications with Visual Studio Code.

By configuring the Visual Studio Code debugger environment for different sample application scenarios,
you gained experience with nearly every aspect of the debugger interface.
You used breakpoints and conditional breakpoints to pause execution at critical locations within your code. 
While execution was paused, you used the VARIABLES, WATCH, and CALL STACK sections of the RUN AND DEBUG view to 
evaluate the state of variables, expressions, and the overall application. 
You also used the execution controls on the Debug toolbar step through and over code lines while your application is running. 
You even used the launch.json file to configure which console to use and to configure the debug environment for projects that include more than one executable.

Without the ability to configure and use the Visual Studio Code debugger tools, 
you wouldn't be able to isolate and fix code bugs in a timely manner.

Reference materials
You can find additional information about the Visual Studio Code debugger and launch configurations 
here: https://code.visualstudio.com/docs/editor/debugging.

You can find additional information about .NET debugging in Visual Studio Code 
here: https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger.md.

You can find additional information about configuring the C# debugger 
here: https://code.visualstudio.com/docs/csharp/debugger-settings.
*/

/////////////////End of this module////////////////////////////////////////
