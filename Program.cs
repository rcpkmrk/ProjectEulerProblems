using System;
internal class Multiples_of_3_or_5
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum = sum + i;
            }            
        }
        Console.WriteLine(sum);       
    }
}
