////////////////////////////////////////////////////
//2025/2/23; 2025/9/6
//Module 6:  Debugging and Exception Handling
//6 units
//Review the principles of code debugging and exception handling
////////////////////////////////////////////////////
//1. Intro
// Examine the code debugging process and the benefits provided by code debuggers, 
// and learn what an exception is and how exceptions are used in an application.
/*
Learning objectives:
1. Review the responsibilities for software testing, debugging, and exception handling.
2. Examine the code debugging process and the benefits provided by code debugger tools.
3. Examine what an exception is and the options for managing exceptions in your code. 
*/
//2 Get started with testing, debugging, and exception handling
//- software development process can involve a lot of testing. 
//- approaches to the software development process that are based on testing, such as test-driven development.
//- Software testing categories can be organized under the types of testing, the approaches to testing, 
//   or a combination of both. One way to categorize the types of testing is to split testing 
//   into Functional and Nonfunctional testing. 
// Functional testing:     Unit testing - Integration testing - System testing - Acceptance testing
// Nonfunctional testing:  Security testing - Performance testing - Usability testing - Compatibility testing
// 
// Note
//Since software testing is such a large topic, and since it's often performed by a separate job role, 
//formal approaches to software testing won't be discussed in this module.
////////////////////////////////////////////////////////
//Code debugging and developer responsibilities:


/* 
string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

//Console.WriteLine("The final name is: " + students[studentCount]);  //this will produce an error
Console.WriteLine("The final name is: " + students[studentCount - 1]); //corrected code 
*/

// The above code snippet generate compilation error... in the Console writeline students[]
// The final name in the array should be accessed using students[studentCount - 1].

//2025/9/6 reviewed notes and re-run the program
//output:
//Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//   at Program.<Main>$(String[] args) in C:\Temp\CsharpProjects\TestProject\Module6\Program-Module6_1-6units_ErrorHandlig.cs:line 35
//after correction:
//output: The final name is: Jeong 
/////////////////////////////////////////////////////
//Summary and Recap
/*
Exception handling and developer responsibilities
As you read earlier, errors that occur during the application runtime are referred to as exceptions. 
If an application generates an exception, and that exception isn't managed in code, it can result in the application being shut down.

Handling exceptions is definitely a responsibility of the developer. 
C# provides a way for you to "try" the code that you know might generate an exception, 
and a way for you to "catch" any exceptions that do occur.

Recap:
Testing, debugging, and exception handling are all important tasks for software developers.
Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
Exception handling is the process of managing errors that occur during runtime, 
and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.
*/
///////////////////////////////////////////////////////////////
//Unit 3: Examine the code debugger approach to debugging code
/*
Code debugging process
When you notice a bug in your code, it can be tempting to try a direct approach. 
You know, that quick scan where you think the issue might be. 
If it pays off in the first 30 seconds, great, but don't let yourself be sucked in. 
Don't keep going to that next spot, and the next. 
Don't let yourself throw time against the following approaches:

Reading through your code (just one more time) hoping that this time the issue jumps out at you.
Breadcrumbing a few Console.WriteLine("here") messages in your code to the track progress through your app.
Rerunning your app with different data. Hoping that if you see what works, you'll understand what doesn't work.
You might have experienced various degrees of success with these methods, but don't be fooled. There is a better way.

The one approach that's commonly regarded as being the most successful is using a debugger. 
But what's a debugger exactly?
------------------------------------
A debugger is a software tool used to observe and control the execution flow of your program with an analytical approach.
Debuggers help you isolate the cause of a bug and help you resolve it. 
A debugger connects to your code using one of two approaches:

By hosting your program in its own execution process.
By running as a separate process that's attached to your running program.
Debuggers come in different flavors. 
Some work directly from the command line while others come with a graphical user interface. 
Visual Studio Code integrates debugger tools in the user interface.
*/
/*
Every debugger has its own set of features. The two most important features that come with almost all debuggers are:

Control of your program execution. You can pause your program and run it step by step, 
which allows you to see what code is executed and how it affects your program's state.

Observation of your program's state. 
For example, you can look at the value of your variables and function parameters at any point during your code execution.

Mastering the use of a code debugger is an important skill. 
///////////
Recap
//////////////
Here are a few important things to remember from this unit:

Code debugging is a crucial skill in the software development process that every developer learns.
The best approach to debugging your applications is to use a debugger, 
not rereading your code five times or adding console.WriteLine() statements throughout your code.
Debuggers enable you to pause your application, step through your code line-by-line, 
and observe the state of variables and function parameters.
*/
/////////////////////////////////////////////////////////////////////
//Unit 4 of 6: Examine exceptions and how exceptions are used
/*
What are exceptions?
Here is a more formal definition that describes what an exception is and how an exception is used in a C# application:

**In C#, errors in the program at runtime are propagated through the program by using a mechanism called exceptions. 
**Exceptions are thrown by code that encounters an error and caught by code that can correct the error. 
**Exceptions can be thrown by the .NET runtime or by code in a program. 
**Exceptions are represented by classes derived from Exception. 
**Each class identifies the type of exception and contains properties that have details about the exception.

Microsoft's documentation on exceptions goes into great detail. 
However, this definition provides the information that you need right now. Specifically, you need to understand two things:
1. You need to understand what exceptions are.
2. You need to understand how to use exceptions in your applications.

You can think of an exception as a variable that has extra capabilities. 
ou can do the same type of things with exceptions that you do with variables, for example:
1. You can create different types of exceptions.
2. You can access the contents of an exception.

/------------------------------------------------------
What does it mean to "throw" and "catch" an exception?
The terms "throw" and "catch" can be explained by evaluating the definition of an exception.

The second sentence of the definition says 
"Exceptions are thrown by code that encounters an error and caught by code that can correct the error". 
The first part of this sentence tells you that exceptions are created by the .NET runtime when an error occurs in your code. 
The second part of the sentence tells you that you can write code to catch an exception that's been thrown. 
In addition, the code that catches the exception can be used to complete a corrective action, 
hopefully mitigating the situation caused by the code that resulted in the error. 
In other words, you can write code that protects your application when an error occurs.

After evaluating that second sentence of the definition, you know the following:

An exception gets created at runtime when your code produces an error.
The exception can be treated like a variable that has some extra capabilities.
You can write code that accesses the exception and takes corrective action.
The remaining portion of the definition tells you that if the .NET runtime detects an error, it generates the exception. 
The exception that's generated contains information about the error that occurred. 
Your code can catch an exception and correct the issue using the information stored in the exception.
///////////////
Recap
////////////////
1. Exceptions are used in C# to propagate errors at runtime, and are represented by classes derived from the Exception class.
2. Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
3. When an exception is caught, code can access its contents and take corrective action to mitigate the error.
4. The .NET runtime generates exceptions when it detects an error and the exception contains information about the type of error that occurred.
*/

////////////////////////////////////////////////////
//unit 5 also a quiz of knowledge check!
//Summary
//Completed
//Your goal was to learn about the code debugging and exception handling processes.
//By examining the code debugging and exception handling processes, 
// you learned about the tools and mechanisms that enable the processes to work. 
// You learned what a code debugger does and the benefits provided by using a code debugger. 
// You also learned about the relationship between errors and exceptions, 
// and how exceptions are thrown and caught during code execution.

//Without the conceptual knowledge that you've gained, you wouldn't be prepared to start using code debugging 
// and exception handling in your C# applications.

//End of this module
/////////////////////////////////////////////////////////////////////