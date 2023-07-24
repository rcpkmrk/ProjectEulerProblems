using System;
using System.Collections.Generic;
internal class Problem_9_Special_Pythagorean_Triplet
{
    static void Main()
    {   
        for(float a=1;a<333;a++)
        {
           for(float b=2;b<499;b++)
        {
            float equation = (500000-1000*b)/(1000-b);
            if(equation == a)
            {
                if(b>a)
                {
                    float c = 1000 - a - b;
                    float Product_abc = a*b*c;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine("Product abc is:"+Product_abc);
                    break; 
                }                
            }
        } 
        }
    }
}
