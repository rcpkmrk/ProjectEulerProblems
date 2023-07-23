using System;
using System.Collections.Generic;
public class Smallest_Multiple
{
    static void Main()
    {
        int SmallestNumber = 1;
        while(SmallestNumber>0)
        {
            int value = divisible(SmallestNumber,20);
            if(value == 1)
            {
                Console.WriteLine(SmallestNumber);
                return;
            }
            SmallestNumber++;
        }    
    }
    static int divisible(int number,int to_number)
    {
        int n = 1;
        while (n<=to_number)
        {
            if(number % n != 0)
            {
                return 0;
            }
            n++;
        }
        return 1;
    }
}