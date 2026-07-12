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
    int maxLength = 0;
    public int DiameterOfBinaryTree(TreeNode root) {

        if (root == null) return 0;

        DiameterOfBinaryTree(root.left);
        DiameterOfBinaryTree(root.right);
        maxLength = Math.Max(maxLength, FindDepth(root.left) + FindDepth(root.right));

        return maxLength;
    }

    private int FindDepth(TreeNode root) {
        if (root == null) return 0;

        return Math.Max(FindDepth(root.left), FindDepth(root.right)) + 1;
    }
}
