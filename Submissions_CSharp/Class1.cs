namespace Submissions_CSharp;

public static class Submissions
{
    public static int Roman_to_Integer(string s)
    {
        Dictionary<char, int> romanmap=  new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int sum = 0;
        int hold = 0;

        for(int i = 0; i < s.Count(); i++)
        {
            if (i+1 < s.Count() && romanmap[s[i]] < romanmap[s[i+1]])
            {
                hold = romanmap[s[i]];
                continue;
            }

            sum += romanmap[s[i]] - hold;
            hold = 0;                
        }

        return sum;
    }
}
