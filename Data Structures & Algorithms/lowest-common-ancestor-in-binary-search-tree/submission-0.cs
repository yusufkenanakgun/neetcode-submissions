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
    TreeNode temp = null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {

        if (p.val > root.val && q.val > root.val) {
            LowestCommonAncestor(root.right, p, q);
        } else if (p.val < root.val && q.val < root.val) {
            LowestCommonAncestor(root.left, p, q);
        } else {
            temp = root;
        }
        return temp;
        
    }
}
