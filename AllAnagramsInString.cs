using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21DaysOfCode
{
    public class AllAnagramsInString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            if (s == p) return new List<int> { 0 };
            List<int> anagrams = new List<int>();
            int n = p.Length - 1;
            int start = 0;


            Stack<char> stackS = new Stack<char>();
            

            for (; start < s.Length; start++)
            {
                int end = start + n;
                for (; end < s.Length; end++) { 
                    //move end up to the end of the word
                    if (IsAnagram(s, p, start, end))
                    {
                        //add to anagrams list                                        
                        anagrams.Add(start);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return anagrams;
        }
        bool IsAnagram(string s, string p, int start, int end)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (var i = start; i <= end; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map.Add(s[i], 1);
                }
            }


            for (var j = 0; j < p.Length; j++)
            {
                if (map.ContainsKey(p[j]))
                {
                    if (map[p[j]] <= 0) return false;
                    map[p[j]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
