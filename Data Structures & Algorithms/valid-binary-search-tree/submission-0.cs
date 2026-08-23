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
    public bool IsValidBST(TreeNode root) {
        return Validate(root, null, null);
    }

    private bool Validate(TreeNode node, long? min, long? max) {
        if (node is null)
            return true;

        if ((min != null && node.val <= min) || (max != null && node.val >= max))
            return false;

        return Validate(node.left, min, node.val) && Validate(node.right, node.val, max);
    }
}
