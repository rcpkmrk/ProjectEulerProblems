using System;
using System.Collections.Generic;
using System.Numerics;
public class P55_LychrelNumbers
{
    static void Main()
    {
        BigInteger number = 1;
        int Lychrel = 0;
        while(number<10000)
        {
            int counter = 1;
            BigInteger temp = number;
            while(counter>0)
            {
                BigInteger sum = temp + reversed(temp);  
                if(sum == reversed(sum))
                {
                    break;
                }               
                temp = sum;
                counter++;
                if(counter == 50)
                {
                    Lychrel++;
                    break;
                }
            }
            number++;
        }
        Console.WriteLine("# of Lychrel Numbers(below 10k): "+Lychrel);
    }
    static BigInteger reversed(BigInteger number)
    {
        BigInteger reversed = 0;
        while(number>0)
        {
            BigInteger remainder = number%10;
            reversed = reversed*10 + remainder;
            number = number/10;
        }
        return reversed;
    }
}