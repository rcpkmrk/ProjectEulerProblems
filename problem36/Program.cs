using System;
using System.Collections.Generic;
// Problem 36: Double-base Palindromes
int number = 1, sum = 0;
string base2 = string.Empty;
while (number < 1000000)
{
    int temp = number, reverse = 0;
    while (temp>0)
    {
        int remainder = temp % 10;
        reverse = reverse*10 + remainder;
        temp = temp / 10;
    }  
    if(reverse==number)
    {
        base2 = Convert.ToString(number,2); 
        char[] binary = base2.ToCharArray();
        Array.Reverse(binary);
        string reversedbase2 = new string(binary);
        
        if(base2 == reversedbase2)
        {
            sum = sum + number;            
        }        
    }          
    number++;
}
Console.WriteLine("sum:"+sum);