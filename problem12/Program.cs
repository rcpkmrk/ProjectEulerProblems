using System;
using System.Collections.Generic;
internal class Problem_12_Highly_Divisible_Triangular_Number
{
    static void Main()
    {   
        int number = 0;
        int i = 1;
        while(i>0)
        {
            number = number + i;
            i = i + 1;
            int k=0;
            for(int j=1;j<=number;j++)
            {
                if (number % j == 0)
                {
                    k++;
                    if(k>500) //calculates in 15 mins
                {
                    Console.WriteLine(number);
                    return;              
                }                
                }
            }                   
        }
    }
}
