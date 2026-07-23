public class Solution {
    Queue< TreeNode > queue = new();
    int count = 1;

    public int GoodNodes(TreeNode root) {

        queue.Enqueue(root);

        while (queue.Count != 0) {
            TreeNode temp = queue.Dequeue();
            if (temp.left != null) {
                queue.Enqueue(temp.left);
                if (temp.left.val < temp.val) {
                    temp.left.val = temp.val;
                } else {
                    count++;
                }
            }
            if (temp.right != null) {
                queue.Enqueue(temp.right);
                if (temp.right.val < temp.val) {
                    temp.right.val = temp.val;
                } else {
                    count++;
                }
            }
        }
        return count;
    }
}
