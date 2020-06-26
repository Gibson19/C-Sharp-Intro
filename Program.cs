using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
       {
            // Prompt the user.
            Console.WriteLine( "Please type: (add/subtract/exit)" );
            string command; // declare a variable
            
            
            // Accept commands.
            while( ( command = Console.ReadLine() ) != "exit" )
            {
                Int result;
                if ( command == "add")

                
                Console.WriteLine( "Enter first number to add: ");
                int firstNum = Int.Parse( Console.ReadLine()  );
                Console.WriteLine( "Enter first number to add: ");
                int secondNum = Int.Parse( Console.ReadLine() );
                result = Addition( firstNum, secondNum ); 
            
            static int Addition( int num1, Int num2 );


            {
                return num1 + num2;
            }        


            }

            {



       }                    



}




    
}
    