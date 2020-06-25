﻿using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw slash mark the beginning of a single line comment
            //We are assigning a string value to a variable
            string myName = "Gibson Patterson";
            
            /* We begin multi-line comments with a forward-slash and asterisk...
            
            Symbols between values or evaluations are considered "operators."
            Below we are using the addition symbol to concatenate two strings.
            (Concatentation means gluing two strings, or texts, together.)
            ...and we end multi-line comments with an asterisk followed by a forward-slash */
            
            
            Console.WriteLine("Hello, " + myName);

            Console.WriteLine("Please enter your name...");

            //Assign variable 'username' to a value entered by the user.
           
            string userName = Console.ReadLine();
            Console.WriteLine("You have entered: "+userName);

            // Instead of traditional concatenation using the addition operator...
            // We can use string interpolation (placeholders) to embed values in
            // a string!
            // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine("Hey {0}, you're looking great today!", userName);




            Console.WriteLine( "makeuppercase".ToUpper() ); // Convert to uppercase...
            Console.WriteLine( "MAKEMELOWERCASE".ToUpper() ); // Convert to lowercase...

            // Substring takes two arguements : 1) Starting character position 2) Number of characters for the string.
            Console.WriteLine( "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 3, 3 ) );
            Console.WriteLine( "XYZ".Length ); // Get the number of characters for the string.

            


        }   


    }
}
