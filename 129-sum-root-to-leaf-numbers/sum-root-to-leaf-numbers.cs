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
    private int sum = 0;
    public int SumNumbers(TreeNode root) {
        Recurse(root, string.Empty);
        return sum;
    }

    private void Recurse(TreeNode node, string numberTillNow){
        var newNumberTillNow = numberTillNow + node.val.ToString();
        if(node.left == null && node.right == null){
            Console.WriteLine(newNumberTillNow);
            int num = int.Parse(newNumberTillNow);
            sum += num;
            return;
        }

        if(node.left != null){
            Recurse(node.left, newNumberTillNow);
        }

        if(node.right != null){
            Recurse(node.right, newNumberTillNow);
        }
    }
}