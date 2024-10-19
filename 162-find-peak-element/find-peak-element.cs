public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length == 1) return 0;
        return FindPeakElementInternal(nums, 0, nums.Length - 1);
    }

    public int FindPeakElementInternal(int[] nums, int leftIndex, int rightIndex){
        if(nums[leftIndex] > nums[leftIndex + 1]){
            return leftIndex;
        }

        if(nums[rightIndex] > nums[rightIndex - 1]){
            return rightIndex;
        }

        int middleIndex = (leftIndex + rightIndex) / 2;

        if(nums[middleIndex] > nums[middleIndex - 1] && nums[middleIndex] > nums[middleIndex + 1]){
            return middleIndex;
        }else if(nums[middleIndex] > nums[middleIndex - 1]){
            return this.FindPeakElementInternal(nums, middleIndex, rightIndex);
        }else{
            return this.FindPeakElementInternal(nums, leftIndex, middleIndex);
        }
    }
}