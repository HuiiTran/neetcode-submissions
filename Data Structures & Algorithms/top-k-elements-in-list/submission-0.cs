public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequentOfNum = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(frequentOfNum.ContainsKey(num)) frequentOfNum[num]++;
            else frequentOfNum[num] = 1;
        }

        List<int[]> arr = frequentOfNum.Select(e => new int[]{e.Value, e.Key}).ToList();
        arr.Sort((a,b) => b[0].CompareTo(a[0]));

        int[] results = new int[k];
        for(int i = 0; i < k; i++){
            results[i] = arr[i][1];
        }
        return results;
    }
}
