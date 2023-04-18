using Submissions_CSharp;

namespace leetcode
{
    public static partial class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Submissions.Roman_to_Integer("III"));
            Console.WriteLine(Submissions.Roman_to_Integer("LVIII"));
            Console.WriteLine(Submissions.Roman_to_Integer("MCMXCIV"));
        }
    }
}