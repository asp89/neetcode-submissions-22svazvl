/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root is null || root == p || root == q)
            return root;

        var leftLca = LowestCommonAncestor(root.left, p, q);
        var rightLca = LowestCommonAncestor(root.right, p, q);

        if (leftLca != null && rightLca != null)
            return root;

        return leftLca != null ? leftLca : rightLca;
    }
}