using System;
using System.Collections.Generic;
// Problem 7: 10001st Prime
int number = 1, counter = 0;
while (number > 0)
{
    int k = 2;
    for(int i=2; i<number; i++)
    {
        if (number % i != 0) { k = k + 1; }
        else { break; }
    }
    if (k == number)
    {
        counter = counter + 1;
        Console.WriteLine("prime number("+counter+"): "+number);
    }
    if(counter == 10001) { return; }
    number++;
}