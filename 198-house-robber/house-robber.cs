public class Solution {
    public int Rob(int[] nums) {
        int[] cache = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            cache[i] = -1;
        }

        return RobInternal(nums, 0, cache);
    }

    private int RobInternal(int[] nums, int currIndex, int[] cache){
        // edge cases
        if(currIndex >= nums.Length) return 0;

        if(cache[currIndex] != -1) return cache[currIndex];

        // case where he robs current house
        var totalStash1 = nums[currIndex] + RobInternal(nums, currIndex + 2, cache);

        // case where he doesn't rob current house
        var totalStash2 = RobInternal(nums, currIndex + 1, cache);

        var totalStash = Max(totalStash1, totalStash2);

        cache[currIndex] = totalStash;

        return totalStash;
    }

    private int Max(int num1, int num2){
        return (num1 > num2) ? num1 : num2;
    }
}