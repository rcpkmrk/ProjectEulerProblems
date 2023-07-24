using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_25_1000_digit_Fibonacci_Number
{
    static void Main()
    {   
        int i=3;
        BigInteger old = 1, older = 1, k = 1;
        while (i>1)
        {
            BigInteger next = old + older;
            older = old;
            old = next;
            k = k + 1;
            BigInteger m = older;
            int digit_number = 1;
            while(m>=10)
            {
                m = m / 10;
                digit_number = digit_number + 1;
            }
            Console.WriteLine("index: "+k+" digits: "+digit_number);
            if (digit_number == 1000)
            {
                break;
            }
            i++;
        }
    }
}