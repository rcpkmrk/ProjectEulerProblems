using System;
using System.Collections.Generic;
// Problem 33: Digit Cancelling Fractions
double numerator = 0, denominator = 0, number = 0;
for(double a=1; a<10; a++)
{
    for(double b=1; b<10; b++)
    {
        for(double c=1; c<10; c++)
        {
            for(double d=1; d<10; d++)
            {
                numerator = (10*a+b);
                denominator = (10*c+d);
                number = numerator/denominator;
                if(a!=b && d!=c && numerator<denominator)
                {
                    if(a==c && b!=d && number==(b/d))
                    {
                        Console.WriteLine(b+"/"+d+" "+numerator+"/"+denominator);
                    }
                    if(a==d && b!=c && number==(b/c))
                    {
                        Console.WriteLine(b+"/"+c+" "+numerator+"/"+denominator);
                    }
                    if(b==d && a!=c && number==(a/c))
                    {
                        Console.WriteLine(a+"/"+c+" "+numerator+"/"+denominator);
                    }
                    if(b==c && a!=d && number==(a/d))
                    {
                        Console.WriteLine(a+"/"+d+" "+numerator+"/"+denominator);
                    }
                }                
            }
        }
    }
}