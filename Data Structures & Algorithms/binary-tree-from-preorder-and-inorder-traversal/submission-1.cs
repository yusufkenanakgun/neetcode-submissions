public class Solution {
    Dictionary<int, int> map = new();
    int preIdx = 0;
    int[] pre;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        pre = preorder;
        for (int i = 0; i < inorder.Length; i++) {
            map[inorder[i]] = i;
        }
        return Build(0, inorder.Length - 1);
    }

    TreeNode Build(int left, int right) {
        if (left > right) return null;          // base case

        int rootValue = pre[preIdx];            // this call's root
        preIdx++;                               // "it increases by one" ← your insight
        TreeNode node = new TreeNode(rootValue);

        int mid = map[rootValue];               // O(1) split point

        node.left  = Build(left, mid - 1);      // LEFT FIRST — this order matters!
        node.right = Build(mid + 1, right);

        return node;
    }
}