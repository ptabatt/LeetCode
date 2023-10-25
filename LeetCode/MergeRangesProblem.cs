using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MergeRangesProblem
    {
        // A stupid HackerRank problem I had during my Oracle interview.
        // Basically, given a 2D Array each with an lower-bound and upper-bound value
        // "Merge" the two arrays into one.
        // i.e. [ [1,3], [2, 4] ] => [ [1, 4] ]
        // [ [1,3], [6, 7] ] => [ [1,3], [6, 7] ] (remains unchanged)
        public int[][] MergeRanges(int[][] ranges)
        {
            if (ranges == null || ranges.Length == 0)
            {
                return null;
            }

            Array.Sort(ranges, (a, b) => { return a[0] - b[0]; });

            var result = new List<int[]>();
            result.Add(ranges[0]);

            for (int i = 1; i < ranges.Length; i++)
            {
                if (ranges[i] == null || ranges[i].Length != 2)
                    return null;

                var last = result.Last();
                
                if (last[1] >= ranges[i][0])
                {
                    last[1] = ranges[i][1];
                }
                else
                {
                    result.Add(ranges[i]);
                }
            }


            return result.ToArray();
        }
    }
}
