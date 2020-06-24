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
        }   


    }
}
