using System;
using System.Collections.Generic;

public class P40_Champernowne_sConstant
{
    static void Main()
    {
        string decimals = "";
        for (int i = 0; i < 200000; i++) // just above a million digits
        {
            decimals = decimals + i.ToString();
        }

        int multi = 1;
        int j = 1;
        while (j<1000000)
        {
            multi = multi*(decimals[j] - '0');
            j*=10;
        }

        Console.WriteLine(multi);
    }
}