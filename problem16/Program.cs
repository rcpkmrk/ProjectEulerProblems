using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_16_Power_Digit_Sum
{
  static void Main()
  {   
    BigInteger number = BigInteger.Pow(2,1000);
    BigInteger sum = 0;
    while(number>=10)
    {      
      BigInteger remainder = number % 10;
      number = number/10;          
      sum = sum + remainder;
    }
    sum = sum + number;
    Console.WriteLine(sum);        
  }
}