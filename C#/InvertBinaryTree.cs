using System;

namespace C_{

    class TreeNode {
    int val;
    public TreeNode left;
    public TreeNode right;
    TreeNode() {}
    TreeNode(int val) { this.val = val; }
    TreeNode(int val, TreeNode left, TreeNode right) {
          this.val = val;
          this.left = left;
          this.right = right;
    }
}
    class InvertBinaryTree{
        public TreeNode InvertTree(TreeNode root) {
            if (root == null) 
                return null;
            TreeNode leftNode = InvertTree(root.left);
            TreeNode rightNode = InvertTree(root.right);
            root.left = rightNode;
            root.right = leftNode;
            return root;
        }
    }
}