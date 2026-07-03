/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {  
    public boolean isSubtree(TreeNode root, TreeNode subRoot) {

        if (root == null) return false;
        if (isSameTree(root, subRoot)) return true;
        return isSubtree(root.left, subRoot) || isSubtree(root.right, subRoot);
    }

    boolean isSameTree(TreeNode p, TreeNode q){
            boolean a, b;
            if(p == null && q == null ) return true;
            else if (p == null || q == null ) return false;
            if(p.val != q.val) return false;
            a = isSameTree(p.left , q.left);
            b = isSameTree(p.right , q.right);
            if(a==true && b == true) return true;
            return false;
        }
}
