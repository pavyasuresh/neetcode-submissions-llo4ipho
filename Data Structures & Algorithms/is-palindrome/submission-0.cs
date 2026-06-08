public class Solution {
    public bool IsPalindrome(string s) {

       StringBuilder forward = new StringBuilder();
       StringBuilder reversed = new StringBuilder();
       for(int i = s.Length-1 ; i>=0; i--)
       {
        if(char.IsLetterOrDigit(s[i]))
        {
             reversed.Append(char.ToLower(s[i]));
        }          
       }

       foreach(char c in s)
       {
        if(char.IsLetterOrDigit(c))
        {
             forward.Append(char.ToLower(c));
        }          
       }


       if( forward.ToString() == reversed.ToString())
       {
        return true;
       }
       return false;
    }
}
