public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            indices[nums[i]] = i;
        }
        for(int i = 0; i < nums.Length; i++){
            int need = target - nums[i];
            if(indices.ContainsKey(need) && indices[need] != i){
                return new int[]{i, indices[need]};
            }
        }
        return new int[0];
    }
}
