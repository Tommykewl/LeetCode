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
    public int GoodNodes(TreeNode root) {
        return this.GoodNodesInternal(root, int.MinValue);
    }

    public int GoodNodesInternal(TreeNode node, int highestValueTillNow){
        if(node == null) return 0;
        var goodNode = (node.val >= highestValueTillNow);
        var highestValue = goodNode ? node.val : highestValueTillNow;

        var goodNodes = (goodNode ? 1 : 0) + this.GoodNodesInternal(node.left, highestValue) + this.GoodNodesInternal(node.right, highestValue);

        return goodNodes;
    }
}