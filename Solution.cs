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
    public int dfs(TreeNode root, ref int result) {
        if (root == null) {
            return -1;
        }
        
        var left = dfs(root.left, ref result);
        var right = dfs(root.right, ref result);
        
        result = Math.Max(result, 2 + left + right);
        
        return 1 + Math.Max(left, right);
    }
    
    public int DiameterOfBinaryTree(TreeNode root) {
        int result = 0;
        
        dfs(root, ref result);
        return result;
    }
}
