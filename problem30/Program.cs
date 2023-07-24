using System;
using System.Collections.Generic;
// Problem 30: Digit Fifth Powers
int i = 2, sum = 0;
while (i>1)
{
    double power = 0;
    int temp = i, j = 2;
    while (j>1)
    {        
        int remainder = i % 10;
        i = i/10;
        power = power + Math.Pow(remainder,5);        
        if (i < 10)
        {
            break;
        }
        j++;
    }
    power = power + Math.Pow(i,5);
    i = temp;
    if (i == 10000000)
        {            
            break;
        }
    if(i == power)
    {
        sum = sum + i;
    }        
    i++;    
}
Console.WriteLine("sum: "+sum);