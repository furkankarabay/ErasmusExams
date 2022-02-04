
//Fibonacci Series That Are Smaller Than 2000

using System;
 
namespace Fibonacci
{
        class Program
        {
 
        static void Main()
        {
            int a = 0, b = 1, result = 0, iteration = 0;
            
            while(result < 2000)
            {
                iteration++;
                Console.Write(result + "  ");
                
                if (iteration <= 1)
                    result = iteration;
                else
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                
            }
        }
    }
    
}