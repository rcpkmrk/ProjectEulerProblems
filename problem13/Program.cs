using System;
using System.Collections.Generic;
using System.Numerics;
internal class Problem_13_Large_Sum
{
    public static void Main()
    {
        string filePath = "C:/Users/samsara/Desktop/ProjectEuler/Solved/problem13/file.txt";
        BigInteger[] bigIntegers = ReadFileAsBigIntegers(filePath);
        BigInteger sum = 0;
        for(int i=0; i<bigIntegers.Length; i++)
        {
            sum = sum + bigIntegers[i];
        }
        Console.WriteLine(sum); 
    }
    public static BigInteger[] ReadFileAsBigIntegers(string filePath)
    {        
        string[] lines = File.ReadAllLines(filePath);
        BigInteger[] bigIntegers = new BigInteger[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            if (BigInteger.TryParse(lines[i], out BigInteger parsedValue))
            {
                bigIntegers[i] = parsedValue;
            }            
        }
        return bigIntegers;
    }
}
