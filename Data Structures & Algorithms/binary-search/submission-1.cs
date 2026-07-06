public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int h = nums.Length - 1;
        while(l <= h){
            int mid = l + (h - l) / 2;

            if(nums[mid] == target)
                return mid;
            if(target > nums[mid]) l = mid + 1;
            else h = mid - 1;
        }
        return -1;
    }
}
