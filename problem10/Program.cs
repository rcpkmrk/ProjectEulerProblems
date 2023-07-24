using System;
using System.Collections.Generic;
// Problem 10: Summation of Primes
long number = 3, sum = 2;
while  (number > 0)
{
    int counter = 2;
    for (int i=2; i<number; i++)
    {
        if (number % i != 0) { counter++; }
        else { break; }
    }
    if (counter == number)
    {
        sum = sum + number;
        Console.WriteLine("number: "+number+" sum: "+sum);
    }
    if (number > 1999998)
    {
        return;
    }
    number += 2;
}