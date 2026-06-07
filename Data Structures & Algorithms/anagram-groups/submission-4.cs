public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>> ();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if(!anagrams.ContainsKey(sorted))
            {
                anagrams[sorted] = new List<string>();
            }

            anagrams[sorted].Add(str);
        }
         
         return anagrams.Select(kv => kv.Value).ToList<List<string>>();
    }
}
