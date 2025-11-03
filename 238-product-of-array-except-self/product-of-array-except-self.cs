public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        int productRight = 1;
        for(int i = nums.Length - 1; i > -1; i--){
            output[i] = productRight;
            productRight = productRight * nums[i];
        }

        int productLeft = 1;
        for(int j = 0; j < nums.Length; j++){
            output[j] = output[j] * productLeft;
            productLeft = productLeft * nums[j];
        }

        return output;
    }
}