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
    public TreeNode InvertTree(TreeNode root) {
        TreeNode tail = root;
        Remove(tail);
        return root;

        
    }
    private void Remove(TreeNode root) {

        if (root == null) return;
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        Remove(root.left);
        Remove(root.right);

    }

}
