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
    public int MaxLevelSum(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int currentLevel = 1;
        int maxLevel = 1;
        int sumLevelTillNow = 0;
        int highestSum = int.MinValue;
        bool swap = false;
        queue.Enqueue(root);
        while(queue.Count() != 0){
            var node = queue.Dequeue();
            if((swap && node.val < 100001) || (!swap && node.val > 100000)){
                swap = ! swap;
                if(sumLevelTillNow > highestSum){
                    highestSum = sumLevelTillNow;
                    maxLevel = currentLevel;
                }
                sumLevelTillNow = 0;
                currentLevel++;
            }

            sumLevelTillNow += node.val - (swap ? 200001 : 0);

            if(node.left != null){
                node.left.val = swap ? node.left.val : node.left.val + 200001;
                queue.Enqueue(node.left);
            }

            if(node.right != null){
                node.right.val = swap ? node.right.val : node.right.val + 200001;
                queue.Enqueue(node.right);
            }
        }

        if(sumLevelTillNow > highestSum){
            highestSum = sumLevelTillNow;
            maxLevel = currentLevel;
        }

        return maxLevel;
    }
}