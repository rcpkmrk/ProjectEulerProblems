public class Solution
{
    public static void Main()
    {
        Solution s = new Solution();
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine(s.numbers(i));
            sum += s.numbers(i).Length;
        }
                        
        Console.WriteLine(sum);
    }

    public string numbers(int number)
    {
        Dictionary<int, string> numbers = new Dictionary<int, string>()
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {60, "sixty"},
            {70, "seventy"},
            {80, "eighty"},
            {90, "ninety"},
            {100, "hundred"},
            {1000, "thousand"}
        };

        if (number == 1000)
        {
            return numbers[1] + numbers[1000];
        }
        else if (number % 100 == 0)
        {
            return numbers[number/100] + numbers[100];
        }
        else if (number > 100 && number % 100 <= 20)
        {
            return numbers[number / 100] + numbers[100] + "and" + numbers[number % 100];
        }
        else if (number > 100 && number % 100 > 20 && number % 100 != 30 && number % 100 
            != 40 && number % 100 != 50 && number % 100 != 60 && number % 100 != 70 && 
            number % 100 != 80 && number % 100 != 90)
        {
            return numbers[number / 100] + numbers[100] + "and" + numbers[(number % 100) 
                / 10 * 10] + numbers[number % 10];
        }
        else if (number > 100 && number % 100 > 20)
        {
            return numbers[number / 100] + numbers[100] + "and" + numbers[number%100];
        }
        else if (number > 20 && number != 30 && number != 40 && number != 50 && number 
            != 60 && number != 70 && number != 80 && number != 90)
        {
            return numbers[number / 10 * 10] + numbers[number % 10];
        }
        else
        {
            return numbers[number];
        }
    }
}
