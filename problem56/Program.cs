using System;
using System.Collections.Generic;
using System.Numerics;
public class P56_PowerfulDigitSum
{
    static void Main()
    {
        BigInteger maximum = 0;
        for(int a=2; a<100; a++)
        {
            for(int b=2; b<100; b++)
            {
                BigInteger temp = DigitSum(BigInteger.Pow(a,b));
                if(maximum < temp)
                {
                    maximum = temp;                    
                }
            }
        }
        Console.WriteLine("max. digital sum: "+maximum);
    }
    static BigInteger DigitSum(BigInteger number)
    {
        BigInteger sum = 0;
        while (number>0)
        {
            BigInteger remainder = number%10;
            sum = sum + remainder;
            number = number/10;
        }
        return sum;
    }
}