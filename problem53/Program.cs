using System;
using System.Collections.Generic;
using System.Numerics;
public class p53_Combinatoric_Selections
{
    static void Main()
    {
        int counter = 1;
        for(int n=23; n<=100; n++)
        {
            for(int r=1; r<=n; r++)
            {
                BigInteger n_r = factorial(n)/(factorial(r)*factorial(n-r));
                if(n_r > 1000000)
                {
                    Console.WriteLine("counter:"+counter+" nr:"+n_r+" n:"+n+" r:"+r);
                    counter++;
                }
            }
        }
    }
    static BigInteger factorial(BigInteger number)
    {
        BigInteger fac = 1;
        for(int i=1; i<=number; i++)
        {
            fac = fac * i;
        }
        return fac;
    }
}