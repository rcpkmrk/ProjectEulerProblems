using System;
using System.Collections.Generic;
using System.Numerics;
public class P44_PentagonNumbers
{
    static void Main()
    {
        BigInteger number = 3000;
        BigInteger minimum = 10000000;
        List<BigInteger> P = new List<BigInteger>();
        HashSet<BigInteger> pentagonalSet = new HashSet<BigInteger>();
        for(BigInteger n=1; n<=number; n++)
        {
            P.Add((n * (3 * n - 1)) / 2);
            pentagonalSet.Add((n * (3 * n - 1)) / 2);
        }           
        for(int k=0; k<number-1; k++)
        {
            for(int j=k+1; j<number; j++)
            {
                BigInteger sum = P[k] + P[j];
                BigInteger difference = BigInteger.Abs(P[k] - P[j]);
                if (k != j && pentagonalSet.Contains(difference) && pentagonalSet.Contains(sum)  && minimum>difference ) 
                {
                    minimum = difference;                    
                    Console.WriteLine("k("+k+"):"+P[k]+" j("+j+"):"+P[j]+" sum:"+sum+" difference:"+difference+" minimum:"+minimum);
                }              
            }
        }                
    }
}