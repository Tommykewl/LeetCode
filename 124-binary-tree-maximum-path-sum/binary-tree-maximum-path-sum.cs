/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int max_path = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        this.MaxGain(root);
        return this.max_path;
    }

    private int MaxGain(TreeNode node){
        if(node == null) return 0;
        int leftGain = this.Max(MaxGain(node.left), 0);
        int rightGain = this.Max(MaxGain(node.right), 0);

        int currentMaxSum = node.val + leftGain + rightGain;
        this.max_path = this.Max(this.max_path, currentMaxSum);

        return node.val + this.Max(leftGain, rightGain);
    }

    private int Max(int a, int b){
        return (a > b) ? a : b;
    }
}