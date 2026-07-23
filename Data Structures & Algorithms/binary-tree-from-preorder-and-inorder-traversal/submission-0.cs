public class Solution {

    Dictionary<int,int> map = new();
    int preIndex = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++) map[inorder[i]] = i;
        return Build(preorder, 0, inorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int left, int right) {

        if (left > right) return null;
        int rootVal = preorder[preIndex++];

        TreeNode node = new TreeNode(rootVal);
        int mid = map[rootVal];
        node.left  = Build(preorder, left, mid - 1);
        node.right = Build(preorder, mid + 1, right);

        return node;
    }
}
