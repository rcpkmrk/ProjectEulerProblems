using System;
using System.Collections.Generic;
internal class Problem_6_Sum_Square_Difference
{
    static void Main()
    {   
        int sum = 0, sumofsqrt = 0;
        for(int i=1;i<101;i++)
        {
            sumofsqrt = sumofsqrt + i*i;
            sum = sum + i;
        }
        int sqrtofsum = sum*sum;
        int difference = sqrtofsum - sumofsqrt;
        Console.WriteLine(sumofsqrt);
        Console.WriteLine(sqrtofsum);
        Console.WriteLine(difference);
    }
}
