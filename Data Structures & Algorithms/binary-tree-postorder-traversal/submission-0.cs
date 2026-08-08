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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> result = new();
        if (root is null)
            return result;
        
        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0) {
            TreeNode current = stack.Pop();
            result.Add(current.val);

            if (current.left != null)
                stack.Push(current.left);
            
            if (current.right != null)
                stack.Push(current.right);
        }
        result.Reverse();
        return result;
    }
}