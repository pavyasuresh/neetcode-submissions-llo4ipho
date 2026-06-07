public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        /*int[] topnNums = nums.GroupBy(x => x)
                        .OrderByDescending(g => g.Count())
                        .Take(k)
                        .Select(key => key.Key)
                        .ToArray();

                        return topnNums;*/

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        List<int>[] bucket = new List<int>[nums.Length +1];

        foreach(var pair in frequency)
        {
            int count = pair.Value;
            int number = pair.Key;
            if(bucket[count] == null)
            {
                bucket[count] = new List<int>();
            }
            bucket[count].Add(number);           
        }

        List<int> result = new List<int>();

        for(int i = bucket.Length -1; i>=0 && result.Count < k; i--)
        {
            if(bucket[i] != null)
            {
                result.AddRange(bucket[i]);
            }
        } 
        return result.ToArray();

    }
}
