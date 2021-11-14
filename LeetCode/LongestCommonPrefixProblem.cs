namespace LeetCode
{
    public class LongestCommonPrefixProblem
    {
        /// <summary>
        /// Write a function to find the longest common prefix string 
        /// amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 2)
                return strs[0];

            var strLPrefix = LongestCommonPrefixBetweenTwoStrings(strs[0], strs[1]);

            for (int i = 2; i < strs.Length; i++)
            {
                strLPrefix = LongestCommonPrefixBetweenTwoStrings(strLPrefix, strs[i]);

                if (string.IsNullOrEmpty(strLPrefix))
                    return strLPrefix;
            }

            return strLPrefix;
        }

        public string LongestCommonPrefixBetweenTwoStrings(string str1, string str2)
        {
            var strLPrefix = string.Empty;

            for (int i =1; i <= str1.Length; i++)
            {
                if (str2.StartsWith(str1.Substring(0, i)))
                    strLPrefix = str1.Substring(0, i);
                else
                    break;
            }
            
            return strLPrefix;
        }
    }
}
