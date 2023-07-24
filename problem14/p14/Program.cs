using System;
using System.Collections.Generic;
internal class Problem_14_Longest_Collatz_Sequence
{
    static void Main()
    {   
        int longest_chain=0;
        double highest_number=0;
        double n=1;
        while (n<1000000) 
        {   
            double m=n;
            int k=2;
            while(m>0)
            {
            if(m % 2 == 0)
            {
                m=m/2;
                k++;
                if(m == 1){break;}                 
            }
            else if(m % 2 == 1)
            {
                m=3*m+1;
                k++;                 
            }                                                         
            }
             if(longest_chain<k)
            {
                longest_chain=k;
                highest_number=n;
            }
            n=n+2; 
            Console.WriteLine("number: "+highest_number);  
            Console.WriteLine("chain: "+longest_chain);                                                 
        }             
    }
}
