using System;
using System.Collections.Generic;
internal class Problem_14_Longest_Collatz_Sequence_Single
{
    static void Main()
    {   
        double n=910107;
        double m=n;
        int k=1;
        Console.WriteLine("number: "+m);
        while(m>0)
        {
            if(m % 2 == 0)
            {
                m=m/2;
                k++;                                 
            }
            else if(m % 2 == 1)
            {
                m=3*m+1;
                k++;                 
            }            
            Console.WriteLine("number: "+m);
            if(m == 1){break;}                                                        
        }              
        Console.WriteLine("chain: "+k);           
    }
}
