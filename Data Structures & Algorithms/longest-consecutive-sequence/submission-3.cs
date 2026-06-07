public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length == 0)
        {
            return 0;
        }
        int len = nums.Length;
        int maxLength = 1;
        int longest = 0;
        HashSet<int> set = new HashSet<int>(nums);

        foreach(int num in set)
        {
            if(!set.Contains(num-1) )
            {
                int currentNum = num;
                maxLength = 1;
                while(set.Contains(currentNum + 1))
                {
                    currentNum++;
                    maxLength++;
                }
                longest = Math.Max(longest, maxLength);
            }
        }
       return longest;
    }
     
}
