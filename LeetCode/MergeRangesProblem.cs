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

        // Update: found it on leetcode https://leetcode.com/problems/merge-intervals/description/
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
            {
                return null;
            }

            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

            var result = new List<int[]>();
            result.Add(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i] == null || intervals[i].Length != 2)
                    return null;

                var last = result.Last();

                if (last[1] > intervals[i][1])
                {
                    continue;
                }
                if (last[1] >= intervals[i][0])
                {
                    last[1] = intervals[i][1];
                }
                else
                {
                    result.Add(intervals[i]);
                }
            }


            return result.ToArray();
        }
    }
}
