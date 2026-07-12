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
    List<List<int>> list = new();
    Queue<TreeNode> queue = new();

    public List<List<int>> LevelOrder(TreeNode root) {
        
        if (root != null) {
            queue.Enqueue(root);
        } else {
            return new List<List<int>>(){};
        }
        while (queue.Count != 0) {
            int count = queue.Count;
            List<int> l1 = new();
            for (int i = 0; i < count; i++) {
                TreeNode temp = queue.Dequeue();
                l1.Add(temp.val);
                if (temp.left != null) {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null) {
                    queue.Enqueue(temp.right);
                }
            }
            list.Add(l1);
        }
       
        return list;
    }
}
