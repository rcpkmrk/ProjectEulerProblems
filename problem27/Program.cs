using System;
using System.Collections.Generic;
using System.Numerics;   
int highest = 0, temp = 0, product = 0, highest_a = 0, highest_b = 0;
for(int a=-999;a<1000;a++)
{
    for(int b=-1000;b<=1000;b++)
    {
        int n = 0;
        while(n>=0)
        {
            int k = 3;
            int eqn = n*n + a*n + b;
            if(eqn<0)
            {
                break;
            }
            for(int j=2;j<eqn;j++)
            {
                if(eqn % j == 0)
                {
                    temp = n;                         
                    break;                            
                }           
                k = k + 1;                                    
            }
            if (k<eqn)
            {
                break;
            }          
            n++;                   
        }                
        if(highest<temp)
        {
            highest = temp;
            product = a*b;
        }
        Console.WriteLine("highest(n): "+highest+" product: "+product);                
    }
}   