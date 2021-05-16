using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chiranthaka!");

            //Passing the name value using parameters. 
            
            /*Method 01 - Using Concatenation.
            -------------------------------------------------------------------
            */
            Console.WriteLine("Hello "+args[0]+"!");


            /*Method 02 - Using String Interpolation
            -------------------------------------------------------------------
            */ 
            Console.WriteLine($"Hello, {args[0]}!");


            /*When we debug the above statements we will stuck with an error. 
            
            Exception has occurred: CLR/System.IndexOutOfRangeException
            An unhandled exception of type 'System.IndexOutOfRangeException' occurred in GradeBook.dll: 'Index was outside the bounds of the array.'
            at GradeBook.Program.Main(String[] args) in D:\MyDev\Projects\C#\GradeBook\src\GradeBook\Program.cs:line <line number>
            
            The resolution for the error is to check the length of the args[] array. Please refer the below example.
                        
            */

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else{
                Console.WriteLine("Hello!");
            }

        }
    }
}
