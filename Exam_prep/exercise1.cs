namespace Exam_prep
{
    public class Numbers
    {
        public int Steps(int x)
        {
            int steps = 0, sum = 0, index = 1;
 
            while (sum < x)
            {
               sum += index;
               steps++;
               index++;
            }
            return steps;
        }
    }
}