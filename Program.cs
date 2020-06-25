using System;

namespace c_sharp_intro
{
    
     static void .Main(string[] args)
        {
            // It is a good idea, for user experience, to prompt the user.
            // Guiding the user is great, as it tells them what is expected.
            Console.WriteLine( "Please enter a string:" );
            string userInput = Console.ReadLine(); // Assignment; collecting data from the user.
            Console.WriteLine( "Please tell us if you want to add or subtract: (add/subtract)" );
            string userOperator = Console.ReadLine();

            // We can use "if" statements to check a "condition".
            // If the "if statement" is true, its code block (marked by curly braces {} will execute.)
            if ( userInput.Length > 0 )
            // Check if the user typed: add
            if ( userOperator == "add" )
            {
                Console.WriteLine( "The user entered a value." );
            } // If there is an "else" statement proceeding an "if", it will only execute if the "if statement" was false.
            else
            {
                Console.WriteLine( "The user did not enter a value." );
                Console.WriteLine( "Please enter the first number:" );
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                int firstNum = Int32.Parse( Console.ReadLine() ); // Convert to integer.
                Console.WriteLine( "Please enter the second number to add:" );
                int secondNum = Int32.Parse( Console.ReadLine() );
                // Calculate the result.
                int result = firstNum + secondNum;
                Console.WriteLine( "{0} + {1} = {2}", firstNum, secondNum, result );
            }
        }
    }