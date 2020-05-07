namespace Part1
{
    using System;
    public class Substrings
    {
        public int Calculate(string a, string b)
        {
            int sum = 0;

            char[] aChars = a.ToCharArray();

            string newWord = "";
            // string newWord2 = "";
            // string newWord3 = "";
            if (a.Length == b.Length)
            {
                if (a == b)
                {
                    sum++;
                }
            }
            else
            {
                string[] words = new string[a.Length];
                int n = 0;
                while (n < 4)
                {
                    for (int i = n; i < b.Length + n; i++)
                    {
                        
                            newWord += aChars[i].ToString();
                        
                        
                    }
                    Console.WriteLine(newWord);
                    words[n] = newWord;
                    if (words[n] == b)
                    {
                        sum++;
                    }
                    newWord = "";
                    n++;
                }
            }
            return sum;
            /*
            for (int i = 1; i <= b.Length + 0; i++)
            {
                newWord2 += aChars[i].ToString();
            }
            for (int i = 2; i <= b.Length + 1; i++)
            {
                newWord3 += aChars[i].ToString();
            }
            */

            //   Console.WriteLine(newWord2);
            //   Console.WriteLine(newWord3);


            //    words[1] = newWord2;
            //    words[2] = newWord3;




        }
    }
}

/*   if (a == b)
           {
               sum++;
           }   
       */


/*    int aLenght = a.Length;
    int bLenght = b.Length;
    Console.WriteLine(aLenght);
    Console.WriteLine(a[0]);
    Console.WriteLine(bLenght);
    Console.WriteLine(b[0]);
 */


/*
           string alf = a.Replace("bab","bob");
           Console.WriteLine(alf);
           string alpha = a.Remove(2);
           char[] aChars = alpha.ToCharArray();
           string bChars = b.Substring(1);
           Console.WriteLine(aChars[0]);
           Console.WriteLine(bChars);*/
/* if (aChars[0] == bChars[0] || aChars[1] == bChars[1] || aChars[2] == bChars[2])
 {
     sum++;
 }*/
