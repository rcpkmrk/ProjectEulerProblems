using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_23_Non_Abundant_Sums
{
    static void Main()
    {
        int number = 28123;
        
        List<int> abundantList = Abundant(number);
        HashSet<int> abundantSum = new HashSet<int>();        

        for (int i = 0; i < abundantList.Count; i++)
        {
            int summ = 0;
            for (int j = i; j < abundantList.Count; j++)
            {
                summ = abundantList[i] + abundantList[j];
                if(summ <= number)
                {
                    abundantSum.Add(summ);
                }
            }
        }
        List<int> sortedAbundantSum = abundantSum.ToList();    
        sortedAbundantSum.Sort();

        int sumofAllNotAbundantSum = 0;
        for (int i = 1; i <= number; i++)
        {
            if (!sortedAbundantSum.Contains(i))
            sumofAllNotAbundantSum += i;
        }
        Console.WriteLine(sumofAllNotAbundantSum);
    }

    static List<int> Abundant(int number)
    {   
        List<int> abundants = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i/2; j++)
            {
                if(i % j == 0)
                {
                    sum += j;
                }
            }
            if(i < sum)
            {
                abundants.Add(i);
            }
        }
        return abundants;        
    }
}