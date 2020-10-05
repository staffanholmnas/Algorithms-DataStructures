namespace Exam_prep
{
    using System.Collections.Generic;
    public class ShortenArray
    {
        public int Calculate(int[] input)
        {
            int inputLength = 0;
            List<int> iteration = new List<int>(); // List to keep track of the values that are left after each iteration.

            while (true)
            {
                inputLength = input.Length; // To check if anything happens in the loop.

                for (int i = 1; i < input.Length; i++) // Iterate through array.
                {
                    if (input[i] == input[i - 1])
                    {
                        if (i == inputLength - 2)
                        {
                            iteration.Add(input[i + 1]); // If a pair is removed and there's one value left, add the last value to the list.
                            break;
                        }
                        else i++; // Else remove pair and continue.
                    }
                    else
                    {
                        if (i == input.Length - 1 && input[i] != input[i - 1])
                        {
                            iteration.Add(input[i - 1]); // If the last two values are different, add both to list.
                            iteration.Add(input[i]);
                        }
                        else iteration.Add(input[i - 1]); // Else add one non-pair value to list of this iteration.
                    }
                }
                // Copy the list of values left after this iteration to a new array and empty the list to start a new iteration.
                input = new int[iteration.Count];
                iteration.CopyTo(input);
                iteration.Clear();

                if (input.Length == inputLength || input.Length <= 1) break; // Break loop if nothing happened or no pair exist.
            }
            return input.Length;
        }
    }
}