using System;
using System.Collections.Generic;

public class P50ConsecutivePrimeSum
{
    static void Main()
    {
        int upperLimit = 1000000;
        int maxCount = 0;  
        int thePrime = 0;      
        List<int> primesToSum = primes(upperLimit);
    
        for (int i = 0; i < primesToSum.Count; i++)
        {
            for (int p = primesToSum.Count; p > 1; p--)
            {
                int sum = 0;
                int count = 0;
                int j = i;
                while(j < p && sum < upperLimit)
                {
                    count++;
                    sum = sum + primesToSum[j];
                    j++;                
                }
                if(maxCount < count && primesToSum.Contains(sum))
                {
                    maxCount = count;
                    thePrime = sum;
                }
            }
        }
        Console.WriteLine("Terms: "+maxCount+", The Prime: "+ thePrime);        
    }
    static List<int> primes(int upperLimit)
    {
        List<int> primes = new List<int>();
        for(int i = 2; i < upperLimit; i++)
        {
            bool isPrime = true;
            for(int j = 2; j*j <= i; j++)
            {
                if(i%j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                primes.Add(i);
            }
        }
        return primes;
    }
}