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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> bfs = new Queue<TreeNode>();
        List<IList<int>> output = new List<IList<int>>();
        if(root == null) return output;
        bfs.Enqueue(root);
        while(bfs.Count > 0){
            var currentCount = bfs.Count;
            List<int> subOutput = new List<int>();
            for(int i = 0; i < currentCount; i++){
                TreeNode t = bfs.Dequeue();
                subOutput.Add(t.val);
                if(t.left != null){
                    bfs.Enqueue(t.left);
                }

                if(t.right != null){
                    bfs.Enqueue(t.right);
                }
            }

            output.Add(subOutput);
        }

        return output;
    }
}