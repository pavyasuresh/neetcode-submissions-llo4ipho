public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach(char c in s.ToLower())
        {
            if(map.ContainsKey(c))
            {
                map[c]++;
            }
            else
            {
                map[c] = 1;
            }
        }

        foreach(char c in t.ToLower())
        {
            if(!map.ContainsKey(c))
            {
                return false;
            }

            map[c]--;

            if(map[c] < 0)
            {
                return false;
            }

        }
        return true;
    }
}
