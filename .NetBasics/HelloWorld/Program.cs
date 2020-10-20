using System;

// a "namespace" is 
namespace HelloWorld
{
    class Program
    {
        // this block of code is a method called "Main"
        // methods needs to reside inside a class that is inside a namespace
        static void Main(string[] args)
        {
            // this is a comment

            // this is a WriteLine function that takes in parameter to output
            // the semi-colon ends a statement
            // "WriteLine" is a member of the "Console" class
            Console.WriteLine("Hello World");

            // this is a ReadLine function that takes in input
            // the "Console" class was written by someone in microsoft (part of the Class Library)
            // the "Console" class has a method called "ReadLine"
            Console.ReadLine();

            // === === the .Net Framework === ===

            // === Class Library: ===
            // Library code that microsoft wrote so that we as developers dont have to worry about them
            // library code to help with math operations, working with text, etc

            // when we used the "Console.WriteLine("Hello World");"
            // we dont care how to write the text all we care about is that the text is written to the console
            // we used a class library "Console"

            // === The Runtime / The Common Language Runtime (CLR): ===
            // takes care of low level details, so that the developer can focus on what the application does
            // and less with how to interact with a computers OS, memory, hardware, etc

            // what is a .Net Assembly
        }
    }
}
