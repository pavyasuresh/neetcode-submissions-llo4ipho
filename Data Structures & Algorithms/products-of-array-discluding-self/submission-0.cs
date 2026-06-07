public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] output = new int[len];

        
        for(int i = 0; i <= len -1; i++)
        {
            int product = 1;
            for(int j = 0; j <= len-1; j++)
            {
                if(i == j)
                {
                    continue;
                }
                else
                {
                    product *= nums[j];
                }
            }
            output[i] = product;
        }
        return output;
    }
}
