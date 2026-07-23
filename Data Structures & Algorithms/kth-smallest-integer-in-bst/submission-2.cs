public class Solution {
    int count = 0;
    int result = -1000;
    public int KthSmallest(TreeNode root, int k) {

        if ( root == null ) return -1;
        if ( count >= k ) {
            return result;
        }

        KthSmallest(root.left, k);

        count++;
        if ( count == k ) {
            result = root.val;
            
            return result;
        }

        KthSmallest(root.right, k);

        return result;
    }
}
