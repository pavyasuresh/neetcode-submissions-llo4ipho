public class Solution {


    public string Encode(IList<string> strs) {
        StringBuilder encodedString = new StringBuilder();
        foreach(string str in strs)
        {
            int len = str.Length;
            encodedString.Append(len + "#" + str);
        }
        return encodedString.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        char[] charArray = s.ToCharArray();
        int i = 0;
        while(i < charArray.Length)
        {
            int j = i;
            while(charArray[j] != '#')
            {
                j++;
            }
            int.TryParse(s.Substring(i,j-i), out int len);
            i = j + 1;
            j = len + i;
            result.Add(s.Substring(i, len));
            i = j;
        }
        return result;
   }
}
