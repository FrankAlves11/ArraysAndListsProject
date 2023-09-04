
using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:  

            // Create an int Array and populate numbers 1-10

            int[] numbers = new int[10];
           
            for (int i = 0; i < 10; i++)
            {                                                                   //Exercise 2
                numbers[i] = i + 1;
            }

            foreach (int num in numbers) 
            {
                Console.WriteLine(num);
                
            }

            /* Create two Lists of type int.
              * Name one List "evens"
            * Name the other List "odds" */

           

            {
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();

                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {                                                           //Exercise 3
                        evens.Add(i);

                    }
                    else
                    {
                        odds.Add(i);
                    }

                }
                Console.WriteLine();
                Console.WriteLine("Even numbers shine bright like a diamond:");
                foreach (int num in evens)
                {
                    Console.Write($"{num}* ");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Odd numbers hop like a pogo stick:");
                Console.WriteLine();
                foreach (int num in odds)
                {
                    Console.Write($"{num}^");
                    Console.WriteLine();
                }
            }
            
            
        }                                                                       
            
            
            

            

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        
    }
}
