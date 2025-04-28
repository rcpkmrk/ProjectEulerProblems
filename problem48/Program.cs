using System;
using System.Collections.Generic;
using System.Numerics;
public class P48_SelfPowers
{
    static void Main()
    {
        BigInteger sum = 0;
        for(int i=1; i<=1000; i++)
        {
            sum = sum + BigInteger.Pow(i,i);
        }
        BigInteger lastTenDigits = sum % BigInteger.Pow(10, 10);
        Console.WriteLine(lastTenDigits);
    }
}