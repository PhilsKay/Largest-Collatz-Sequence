using System;

namespace Largest_Collatz_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong longestChain = 13;
            for(ulong i = 13; i < 1000000; i++)
            {
                if(CollatzSequence(longestChain) < CollatzSequence(i))
                {
                    longestChain = i;
                }
            }
            Console.WriteLine(longestChain);
            Console.WriteLine("With " + CollatzSequence(longestChain) + " terms");
            // Is to return the number of terms of collatz sequence a number contains
            static ulong CollatzSequence(ulong n)
            {
                ulong evenCount = 0;
                ulong oddCount = 0;
                while (n != 1)
                {
                    bool passed = true;
                    if (n % 2 == 0)//is even
                    {
                        n /= 2;
                        evenCount++;
                        if (n % 2 != 0) //did this so after dividing the even and an odd number is got
                        {              // it won't return to the odd below else goes to the return value.
                            passed = false;
                        }
                    }
                    if (n % 2 != 0 && n != 1 && passed == true)//is odd
                    {
                        n = (3 * n) + 1;
                        oddCount++;
                    }
                }
                return (oddCount + evenCount + 1);//return the no of terms
            }
            Console.ReadLine();
        }
    }
}