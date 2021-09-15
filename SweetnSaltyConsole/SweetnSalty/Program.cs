using System;

namespace SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
          // Instaties the values of 3 variables seet, salty, sweetnSalty to 0 respectively
          int sweet = 0;
          int salty = 0;
          int sweetnSalty = 0;

          //creates a for loop to iterate through the values from 1 to 1000
          for(int numbers = 1; numbers <= 1000; numbers++)
          {
            //If there is a multiple of 3 and 5 we are going to print Sweet'nSalty
             
            if(numbers % 3 == 0 && numbers % 5 == 0)
            {
              //every time this prints Sweet'nSalty we increment 
              sweetnSalty++;
              Console.WriteLine("Sweet'nSalty ");
            }
            //And if the numbers is a multiple of just 3 print sweet
            else if(numbers % 3 == 0 )
            {
              //every time this prints Sweet we increment 
              sweet++;
              Console.WriteLine("Sweet ");
            }
            // If the number is a multiple of 5 print Salty
            else if(numbers % 5 == 0)
            {
              //every time this prints Salty we increment 
              salty++;
               Console.WriteLine("Salty ");
            }
            //
            else
            {
               Console.WriteLine(numbers+ ((numbers % 10 == 0) ? "\n" : " "));
            }

          }
            Console.WriteLine("The number of Sweet: {0}\nThe numbers of Salty: {1}\nThe number of Sweet'nSalty: {2}", sweet, salty, sweetnSalty);
        }
        
    }
}
