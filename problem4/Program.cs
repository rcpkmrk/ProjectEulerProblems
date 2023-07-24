using System;
using System.Collections.Generic;
// Problem 4: Largest Palindrome Product
int largest = 0;
for(int a=100; a<1000; a++)
{
  for(int b=100; b<1000; b++)
  {
    int number = a*b;
    int reverse = 0;
    int temp = number;
    while (temp>0)
    {          
      int remainder = temp % 10;  
      reverse = (reverse * 10) + remainder;  
      temp = temp / 10;                       
    } 
    if(number == reverse && largest < reverse) 
    {
      largest = reverse;
      Console.WriteLine("number: "+largest+" a:"+a+" b:"+b);
    }    
  }
}