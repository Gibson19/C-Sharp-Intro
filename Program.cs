using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw slash mark the beginning of a single line comment
            //We are assigning a string value to a variable
            string myName = "Gibson Patterson";
            
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Please enter your name...");

            //Assign variable 'username' to a value entered by the user.
           
            string userName = Console.ReadLine();
            Console.WriteLine("You have entered: "+userName);


            Console.WriteLine( "makeuppercase".ToUpper() ); // Convert to uppercase...
            Console.WriteLine( "MAKEMELOWERCASE".ToUpper() ); // Convert to lowercase...

            // Substring takes two arguements : 1) Starting character position 2) Number of characters for the string.
            Console.WriteLine( "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 3 , ) );




        }   


    }
}
