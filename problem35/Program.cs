using System;
using System.Collections.Generic;

public class P35CircularPrimes
{
    static void Main()
    {
        int upperLimit = 1000000;
        int count = 0;

        HashSet<string> primes = Primes(upperLimit).Select(p => p.ToString()).ToHashSet();
        foreach (var item in primes)
        {

            bool isCircular = true;
            string rotated = item;

            for (int i = 0; i < item.Length; i++)
            {
                rotated = rotated.Substring(1) + rotated[0];

                if(!primes.Contains(rotated))
                {
                    isCircular = false;
                    break;
                }
            }
            
            if (isCircular)
            {
                count++;
                Console.WriteLine(item);
            }
        }
        Console.WriteLine(count);
    }

    static List<int> Primes(int upperLimit)
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


