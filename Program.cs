using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Logical operators .
            Console.WriteLine( true || true ); // is OR
            Console.WriteLine( false || true ); 

            
            // AnND will evaluate to te TRUE only if BOTH 
            Console.WriteLine( true && true ); && is AND
            Console.WriteLine( false && true ); // True.
            Console.WriteLine( 2.25 == 2.25 ); // False.


           // How does this behhave with different data-types?
           // Console.WriteLine( true && true 1 ); DOESNT!

            // Comparitive operators ...
            // "Equal to" check.
            Console.WriteLine(  false == false ); True.
            Console.WriteLine(  true == false ); False            
            Console.WriteLine( 2.25 == 2.25 ); // True.    
            Console.WriteLine( 2.25 == 3.14 ); // False.
            // Console.write( 31.4 == "3.14 ); // Cannot check two diff. types!

            // "Greater than" check.
            Console.WriteLine( 6 < 7 ); // False.
            Console.WriteLine( 10 < 5 ); // False.

            // "Less than" check
            Console.WriteLine( 6 > 7 ); // True.
            Console.WriteLine( 10 > 5 ); // False.

            // "Greater- than-or-equal-to"
            Console.WriteLine( 5 >= 5 ); // False.
            Console.WriteLine( 10 > 5 ); // False.




            
        

        }   


    }
}
