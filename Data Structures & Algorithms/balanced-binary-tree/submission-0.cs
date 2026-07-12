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
    int balance = 0;
    public bool IsBalanced(TreeNode root) {
        Depth(root);
        return (balance >= 0);
        
    }

    int Depth(TreeNode root) {
        if (root == null) return 0;

        int left = Depth(root.left);
        int right = Depth(root.right);
        if (right - left < -1 || right - left > + 1) {
            balance -= 100;
        }
        return Math.Max(left, right) + 1;
    }
}
