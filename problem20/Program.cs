using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_20_Factorial_Digit_Sum
{
    static void Main()
    {   
        BigInteger fac = 1, sum = 0;
        for(int i=100;i>0;i--)
        {
            fac = fac * i;
        }
        while(fac>=10)
        {      
          BigInteger remainder = fac % 10;
          fac = fac/10;          
          sum = sum + remainder;
        }
        sum = sum + fac;
        Console.WriteLine(sum);        
    }
}