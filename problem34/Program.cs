using System;
using System.Collections.Generic;
using System.Numerics;
// Problem 34: Digit Factorials
BigInteger i = 10, m = 0;
while (i>=10)
{
    BigInteger fac2 = 1, sum = 0;
    m = i;
    while(m>=10)
    {
        BigInteger fac = 1;
        BigInteger remainder = m % 10;
        for(int j=1; j<=remainder; j++)
        {
            fac = fac * j;
        }
        sum = sum + fac;
        m = m / 10;
    } 
    for(int k=1; k<=m; k++)
    {
        fac2 = fac2 * k;
    }
    sum = sum + fac2;
    if(sum == i)
    {
        Console.WriteLine("number: "+i);
    }   
    if(i == 100000)
    {
        break;
    }
    i++;
}