namespace Part1
{
    public class Substrings
    {
        public int Calculate(string a, string b)
        {
            int sum = 0;
            string newWord = "";
            char[] aChars = a.ToCharArray();      
            string[] words = new string[a.Length];
            
            for (int n = 0; n < a.Length - (b.Length - 1); n++)
            {
                for (int i = n; i < b.Length + n; i++)
                {
                    newWord += aChars[i].ToString();
                }
                words[n] = newWord;
                if (words[n] == b)
                {
                    sum++;
                }
                newWord = "";
            }
            return sum;
        }
    }
}