using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_24_Lexicographic_Permutations
{
    static void Main()
    {   
        int[] numbers =  {0,1,2,3,4,5,6,7,8,9};        
        int count = 2;

        while (true)
        {
            int P_X_Index = -1;

            for(int i = numbers.Length-1; i > 0 ; i--)
            {      
                if(numbers[i-1] < numbers[i])
                {
                    P_X_Index = i-1;     
                    break;
                }
            }

            if(P_X_Index == -1)
            {
                break;
            }

            int P_Y_Index = -1;

            for(int j = P_X_Index+1; j < numbers.Length; j++)
            {
                P_Y_Index = numbers.Length-1;
                if(numbers[P_X_Index] > numbers[j])
                {
                    P_Y_Index = j-1;
                    break;
                }
            }

            int temp = numbers[P_X_Index];
            numbers[P_X_Index] = numbers[P_Y_Index];
            numbers[P_Y_Index] = temp;

            int k = 1;
            while(true)
            {
                if(numbers[P_X_Index+k] == numbers[numbers.Length-k] || P_X_Index+k > numbers.Length-k)
                {
                    break;
                }
                else
                {
                    int temp2 = numbers[P_X_Index+k];
                    numbers[P_X_Index+k] = numbers[numbers.Length-k];
                    numbers[numbers.Length-k] = temp2;  
                    k++; 
                }                   
            }
            if(count == 1000000)
            {
                string millionth = string.Join("", numbers);
                Console.WriteLine(millionth);
                break;
            }
            count++;
        }  
    }
}