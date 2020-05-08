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
/*

I want to go through string a with string b, starting at the first character and then the next character the second time, 
then the third character and so on... I want to stop when the last character of b reaches the last character of a. 
The code above does this by putting each character from string a to an array, then building new words that have
the same length as b, and that are put in a new array. Each new word moves up the string by 1 character. These new words
can then be compared with string b, if they match, 1 is added to sum. Not the most elegant solution, but it works.
Tested with both large and small strings for both a and b.

*/