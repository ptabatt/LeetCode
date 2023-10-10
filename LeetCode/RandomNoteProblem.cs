using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RandomNoteProblem
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dctNote = new Dictionary<char, int>();
            var dctMag = new Dictionary<char, int>();

            foreach (var c in ransomNote)
            {
                if (dctNote.ContainsKey(c))
                {
                    dctNote[c] += 1;
                }
                else
                {
                    dctNote[c] = 1;
                }
            }

            foreach (var c in magazine)
            {
                if (dctMag.ContainsKey(c))
                {
                    dctMag[c] += 1;
                }
                else
                {
                    dctMag[c] = 1;
                }
            }

            foreach (var entry in dctNote)
            {
                int noteVal; 
                if (!dctMag.TryGetValue(entry.Key, out noteVal))
                {
                    return false;
                }

                if(entry.Value > noteVal)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
