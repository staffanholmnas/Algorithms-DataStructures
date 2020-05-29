using System.Collections.Generic;

namespace Part4
{
    public class SmallestDistance
    {
        public List<int> list;

        public SmallestDistance()
        {
            this.list = new List<int>();
        }

        public void Add(int x)
        {
            list.Add(x);
        }

        public int Calculate()
        {
            list.Sort();
            int smallestDiff = 1000000000, diff = 0;
            if (list.Count == 1 || list.Count == 0)
            {
                return 0;
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                diff = list[i + 1] - list[i];
                if (diff < smallestDiff)
                {
                    smallestDiff = diff;
                }
            }
            return smallestDiff;
        }
    }
}