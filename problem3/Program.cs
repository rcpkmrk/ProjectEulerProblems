using System;
using System.Collections.Generic;
//Problem 3: Largest Prime Factor
long number = 600851475143, largest_prime = 0, i = 3;
while (i < number)
{
    int counter = 2;
    if (number % i == 0)
    {        
        for(int j=2; j<i; j++)
        {
            if (i % j != 0) { counter = counter + 1;}
            else { break; }
        }        
    }
    if(counter == i)
    {
        largest_prime = i;
    } 
    Console.WriteLine("largest prime: "+largest_prime+" number: "+i);
    i += 2;
}