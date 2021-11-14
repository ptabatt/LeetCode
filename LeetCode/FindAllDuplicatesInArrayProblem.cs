using System.Collections.Generic;

namespace LeetCode
{
    public class FindAllDuplicatesInArrayProblem
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var colResult = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        if (!colResult.Contains(nums[i]))
                        {
                            colResult.Add(nums[i]);
                        }
                        break;
                    }
                }
            }

            return colResult;
        } 
    }

    public class FindAllDuplicatesInArrayProblemSecondAttempt
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var colResult = new List<int>();
            var dctOccurrences = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dctOccurrences.ContainsKey(num))
                    dctOccurrences[num] += 1;
                else
                    dctOccurrences[num] = 1;
            }

            foreach (var occ in dctOccurrences)
            {
                if (occ.Value > 1)
                    colResult.Add(occ.Key);
            }

            return colResult;
        }
    }
}
