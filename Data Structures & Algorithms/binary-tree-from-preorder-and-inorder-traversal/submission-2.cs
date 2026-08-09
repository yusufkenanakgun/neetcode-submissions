public class Solution {
    Dictionary <int, int> map = new();
    int[] pre;
    int preIdx = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++) {
            map[inorder[i]] = i;
        }
        pre = preorder;

        return Build(0, preorder.Length - 1);   
    }

    TreeNode Build(int left, int right) {
        if (left > right) return null;

        int rootValue = pre[preIdx];
        preIdx++;
        TreeNode node = new TreeNode(rootValue);
        int mid = map[rootValue];

        node.left = Build(left, mid - 1);
        node.right = Build(mid + 1, right);

        return node;
    }


    
}