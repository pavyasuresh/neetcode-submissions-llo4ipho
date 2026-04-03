public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> withoutDuplicate = new HashSet<int>();
        foreach(int n in nums)
        {
            if(withoutDuplicate.Contains(n))
            {
                return true;
            }
            else
            {
                withoutDuplicate.Add(n);
            }
        }
        return false;
    }
}