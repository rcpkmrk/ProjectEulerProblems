using System;
using System.Collections.Generic;
using System.Numerics;
// Problem 29: Distinct Powers
int a_max = 100, b_max = 100, k = 0;
List<BigInteger> number = new List<BigInteger>();
for (int a = 2; a <= a_max; a++)
{
    for (int b = 2; b <= b_max; b++)
    {         
        BigInteger temp1 = BigInteger.Pow(a,b);
        if (number.Contains(temp1) == false)
        {
            number.Add(temp1);
            k = k + 1;
        }        
    }
}
Console.WriteLine("Distinct Terms: "+k);