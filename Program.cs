using System.Text;

namespace Assignment12._3._1
{
    internal class Program
    {
        public static string RemoveSameAdjacentChars(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (result.Length > 0 && result[result.Length - 1] == c)
                {
                    result.Remove(result.Length - 1, 1);
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveSameAdjacentChars("abbaca"));
        }
    }
}
