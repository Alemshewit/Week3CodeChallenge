using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           // Stopwatch sw = Stopwatch.StartNew();
            List<int> primes = new List<int>();
            for (int i = 0; i <= 10001 ; i++)
            {
                if (IsPrime(i))
                {
                    List<int> primes = IsPrime[i].List<int>;                   
                    i++;
                }

            }
            
            Console.WriteLine();
           // Console.WriteLine("Time used (float): {0} ms", sw.Elapsed.TotalMilliseconds);
            //Console.WriteLine("Time used (rounded): {0} ms", sw.ElapsedMilliseconds);
            Console.ReadKey();

        }

       //// static bool IsPrime(Int64 p)
       // {
       //     if (p % 2 == 0) return false;
       //     Int64 max = (Int64)Math.Ceiling(Math.Sqrt(p));
       //     for (Int64 divisor = 3; divisor < max; divisor += 2)
       //     {
       //         if (p % divisor == 0) return false;
       //     }
       //     return true;
       // }

        static bool IsPrime(int number)
        {
            //first check to see if the number is either 0 or 1 since those 
            //numbers are not prime we eliminate them by checking
            if (number == 0 || number == 1)
            {
                return false;
            }

            //we check to see if the given number is 2 and return true
            //if it is, since 2 is the only even number that is only divisible 
            //by 1 and itself
            else if (number == 2)
            {
                return true;

            }
            //then we check to see if the given number is even, and return false 
            //if it is since all even numbers, 2 excepted are not prime
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            //if the above conditions aren't met, then it means the given number
            //is odd and we loop through the odd number to see if it is prime or  
            //not since only some odd numbers are prime
            {
                //loop through the number until it reaches half its value, since
                //a number is only divisible by numbers half its value and lower,
                //and increment the loop by 2 every loop 
                for (int i = 3; i < number / 2; i += 2)
                {
                    //if the number is divisible by i then return false, if not 
                    //return true
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static void EvenFibbonnacciSequencer(int maxValue)
        {
           
        }

      

    //static  int GetSum( int maxValue)
    //{
    //     = prevNum1 + prevNum1;
    //    if (prevNum1 % 2 == 0)
    //    {
    //        sum += prevNum1;
    //    }
    //    if (prevNum2 % 2 == 0)
    //    {
    //        sum += prevNum2;
    //    }
    //    int fNum = 0;
    //    while (prevNum2 <= max)
    //    {
    //        fNum = prevNum1 + prevNum2;
    //        if (fNum % 2 == 0)
    //        {
    //            //is an even number...add to total
    //            sum += fNum;
    //        }
    //        prevNum1 = prevNum2;
    //        prevNum2 = fNum;

    //    }

    //    return sum;
    //}

}


        }

        static void LongestCollatzSequence()
        {
}

    
    

