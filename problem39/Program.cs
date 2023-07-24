using System;
using System.Collections.Generic;
// Problem 39: Integer Right Triangles
int p = 12, max = 0;
while (p<=1000)
{
    int count = 0;
    for (int b=2; b<(p/2); b++)
    {        
        for (int a=1; a<b; a++)
        {
            int c = p - (a+b);
            if (a*a+b*b == c*c && c>b && c>a)
            {
                count++;
            }
        }        
    }
    if (max < count)
        {
            max = count;
            Console.WriteLine(p);
        }
    p++;
}