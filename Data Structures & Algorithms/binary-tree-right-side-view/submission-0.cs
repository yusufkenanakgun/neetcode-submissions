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
    Queue<TreeNode> queue = new();
    List<int> list = new();

    public List<int> RightSideView(TreeNode root) {
        
        if (root == null) {
            return new List<int>(){};
        } else {
            queue.Enqueue(root);
        }

        while (queue.Count != 0) {
            int count = queue.Count;
            
            for (int i = 0; i < count; i++) {
                TreeNode temp = queue.Dequeue();
                if (i == count - 1) {
                    list.Add(temp.val);
                }
                if (temp.left != null) {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null) {
                    queue.Enqueue(temp.right);
                }
            }
        }
        return list;
    }
}
