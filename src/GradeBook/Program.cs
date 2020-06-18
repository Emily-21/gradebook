using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) //string array= a collection of strings, 0 or more passed in as args... args = arguements, args passed to the app 
        //this is method named Main, the 'entry point' to the application, start executing this
        {     
            List<double> grades = new List<double>() {12.7, 16.2, 12.2, 14.2};
            grades.Add(16.3);
            

            double total = 0.0;
            foreach(double number in grades) 
            {
              total += number;
            }
            total /= grades.Count;
            Console.WriteLine($"the avg grade is {total:N1}"); //to 1 decimal place
            
        //     if (args.Length > 0)
        //     {
        //         Console.WriteLine($"Hello, {args[0]}!"); // here we are saying, check the parameters of the method!
        //         //which, we are pushing through the command line 'dotnet run Emily'
        //      }
        //    else 
        //     {
        //         Console.WriteLine("hello");
        //     }
         }
    }
}