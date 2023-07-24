using System;
using System.Collections.Generic;
internal class Problem_2_Even_Fibonacci_Numbers
{
    static void Main()
    {   
        int[] fibonacci = new int[102];
        fibonacci[0]=1;
        fibonacci[1]=2;
        int sum = 0;
        for (int i = 0; i < 100; i++)
        {            
            fibonacci[i+2] = fibonacci[i+1]+fibonacci[i];
        }
        for(int j=0;j<100;j++)
        {
            if(fibonacci[j]<4000000)
            {
                if (fibonacci[j] % 2 == 0)
                {
                    sum = sum + fibonacci[j];
                }                
            }
            else
            {
                break;
            }            
        }
        Console.WriteLine(sum);               
    }
}
