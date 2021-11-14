namespace LeetCode
{
    public class PalindromeNumberProblem
    {
        public bool IsPalindrome(int x)
        {
            string strX = x.ToString();

            int j = strX.Length - 1;

            for (int i=0; i < strX.Length/2; i++)
            {
                if (i == j)
                    return true;

                if (strX[i] != strX[j])
                    return false;

                j--;
            }

            return true;
        }
    }
}
