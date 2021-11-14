using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class AddBinaryProblem
    {
        /// <summary>
        /// Given two binary strings a and b, return their sum as a binary string.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary(string a, string b)
        {
            return IntToBinary(BinaryToInt(a) + BinaryToInt(b));
        }

        public int BinaryToInt(string a)
        {
            int result = 0;
            double dHighestExponent = Math.Pow(2, (a.Length - 1));

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '1')
                    result += (int)dHighestExponent;

                dHighestExponent /= 2;
            }

            return result;
        }

        public string IntToBinary(System.Numerics.BigInteger x)
        {
            char[] buff = new char[10000];

            for (int i = 31; i >= 0; i--)
            {
                int mask = 1 << i;
                buff[31 - i] = (x & mask) != 0 ? '1' : '0';
            }

            return RemoveTrailingZeros(new string(buff));
        }

        public string RemoveTrailingZeros(string s)
        {
            var sb = new StringBuilder();

            bool bHasTrailingZeros = true;

            foreach (var c in s)
            {
                if (c == '1')
                {
                    bHasTrailingZeros = false;
                    sb.Append(c);
                }
                else if (c == '0' && !bHasTrailingZeros)
                {
                    sb.Append(c);
                }
            }

            if (bHasTrailingZeros)
                sb.Append('0');

            return sb.ToString();
        }
    }
}
