public class Solution {
    public int Trap(int[] height) {
        if(height.Length == 0) return 0;
        int totalWater = 0;
        int left = 0;
        int right = height.Length - 1;
        int maxLeft = height[left], maxRight = height[right];
        while(left < right){
            if(maxLeft < maxRight){
                left++;
                maxLeft = Math.Max(maxLeft, height[left]);
                totalWater += maxLeft - height[left];
            }
            else{
                right--;
                maxRight = Math.Max(maxRight, height[right]);
                totalWater += maxRight - height[right];
            }
        }
        return totalWater;
    }
}
