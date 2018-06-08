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
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

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
                if(arr[i] != null)
                {
                    current.left = new TreeNode(arr[i].Value);
                    queue.Enqueue(current.left);
                }
                
                if( i+1 < arr.Length)
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
 
        public static int MaxDepth(TreeNode root)
        {
            return 0;
        }
        
    }
}
