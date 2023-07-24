using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_21_Amicable_Numbers
{
    static void Main()
    {           
        int sum = 0;
        for(int number=2;number<10000;number++)
        {   
            int k = 0, m = 0;
            for(int i=1;i<number;i++)
            {
                if(number % i == 0)
                {
                    k = k + i;
                }
            }
            int d_a = k;
            for(int j=1;j<d_a;j++)
            {
                if(d_a % j == 0)
                {
                    m = m + j;
                }
            }
            int d_b = m;
            if(d_b == number && d_a != d_b)
            {
                sum = sum + d_a + d_b;
            }
        }          
        Console.WriteLine("sum: "+sum/2);      
    }
}