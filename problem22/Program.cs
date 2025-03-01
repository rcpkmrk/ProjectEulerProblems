public class Solution
{
    public static void Main()
    {
        Solution s = new Solution();
        string[] names = s.SaveNames();
        Console.WriteLine(s.Score(names));
    }

    public string[] SaveNames()
    {
        string[] names = File.ReadAllText("names.txt")
                                 .Replace("\"", "") // Remove double quotes
                                 .Split(',')        // Split by comma
                                 .Select(name => name.Trim()) // Trim spaces
                                 .OrderBy(name => name) // Sort alphabetically
                                 .ToArray();
        return names;
    }

    public int Score(string[] names)
    {
        Dictionary<char, int> letterScores = new Dictionary<char, int>
        {
            { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 },
            { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 }, { 'J', 10 },
            { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, { 'O', 15 },
            { 'P', 16 }, { 'Q', 17 }, { 'R', 18 }, { 'S', 19 }, { 'T', 20 },
            { 'U', 21 }, { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 },
            { 'Z', 26 }
        };

        int total = 0;
        for (int i = 0; i < names.Length; i++)
        {
            int nameScore = 0;
            foreach (char letter in names[i])
            {
                nameScore += letterScores[letter];
            }
            total += nameScore * (i + 1);
        }

        return total;
    }
}
