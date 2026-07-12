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
    public bool IsValidBST(TreeNode root) {
        return IsInterval(root, long.MinValue, long.MaxValue);   
    }


    bool IsInterval(TreeNode root, long min, long max) {
        if (root == null) return true;

        if ( root.val <= min || root.val >= max ) return false; 
        
        bool leftOK = IsInterval(root.left, min, root.val);
        bool rightOK = IsInterval(root.right, root.val, max);

        return leftOK && rightOK ;
    }


}
