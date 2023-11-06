namespace LeetCode
{
    public class ReverseWordsInStringProblem
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var sb = new System.Text.StringBuilder();

            for (var i = words.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    sb.Append(words[i] + " ");
                }
            }

            return sb.ToString().Trim(' ');
        }
    }
}
