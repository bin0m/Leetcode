using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Trees
    {

        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }

        // helper method
        public static TreeNode CreateBinaryTree(int?[] arr)
        {
            if (arr == null || arr.Length < 1)
            {
                return null;
            }

            TreeNode root = new TreeNode(arr[0].Value);
            //int levels = (int)Math.Log(arr.Length, 2);
            Queue<TreeNode> queue = new Queue<TreeNode>(arr.Length);
            queue.Enqueue(root);
            for (int i = 1; i < arr.Length; i++)
            {
                TreeNode current = queue.Dequeue();
                if (arr[i] != null)
                {
                    current.left = new TreeNode(arr[i].Value);
                    queue.Enqueue(current.left);
                }

                if (i + 1 < arr.Length)
                {
                    if (arr[i + 1] != null)
                    {
                        current.right = new TreeNode(arr[i + 1].Value);
                        queue.Enqueue(current.right);
                    }

                    i++;
                }
            }

            return root;
        }

        // Maximum Depth of Binary Tree
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        // Validate Binary Search Tree
        public static bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            bool isValid = true;

            if (root.left != null)
            {
                isValid = IsValidBST(root.left, long.MinValue, root.val);
            }

            if (isValid && root.right != null)
            {
                isValid = IsValidBST(root.right, root.val, long.MaxValue);
            }

            return isValid;
        }

        // (helper for IsValidBST) checks all BST values in range [greaterThan,lessThan]
        private static bool IsValidBST(TreeNode root, long greaterThan, long lessThan)
        {
            bool isValid = root.val > greaterThan && root.val < lessThan;

            if (isValid && root.left != null)
            {
                isValid = IsValidBST(root.left, greaterThan, root.val);
            }

            if (isValid && root.right != null)
            {
                isValid = IsValidBST(root.right, root.val, lessThan);
            }

            return isValid;
        }

        // Symmetric Tree
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);
        }

        // (helper for IsSymmetric) check equality between a node and b node, and also between there childs (in mirror)
        public static bool IsSymmetric(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            bool isSymmetric = (a.val == b.val) 
                               && IsSymmetric(a.left, b.right) 
                               && IsSymmetric(a.right, b.left);
            return isSymmetric;

        }
    }
}
