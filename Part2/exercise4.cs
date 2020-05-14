namespace Part2
{
    public class Revolutions
    {
        public int Calculate(int[] t)
        {
            int revolutions = 0;
            int adder = 1;
       
            // Revolutions.
            for (int i = 1; i <= t.Length; i++)
            {   
                // Positions in the array.
                for (int j = 0; j <= t.Length - 1; j++)
                {
                    // Add 1 when an integer is found to pick up next integer.
                    if (t[j] == adder)
                    {
                        adder++;

                        // When the last integer has been picked up, store the number of revolutions.
                        if (adder == t.Length + 1)
                        {
                            revolutions = i; 
                        }
                    }
                }
            }
            return revolutions;
        }
    }
}