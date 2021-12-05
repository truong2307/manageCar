﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.BinarySearchTree
{
    public static class BinaryTree
    {
        public class Node
        {
            public int Key { get; set; } 
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node() 
            {
            }
        }

        private static Node CreateNode(int nodeValue)
        {
            Node node = new Node
            {
                Key = nodeValue,
                Left = null,
                Right = null,
            };
            return node;
        }

        public static void InsertNode (this Node root, int nodeValue)
        {
            Node nodeNew = root;
            Node parent = null;
            if (nodeNew.Key == 0)
            {
                nodeNew.Key = nodeValue;
            }
            else
            {
                //find destination want to insert of request node value  
                while (nodeNew != null && nodeNew.Key != nodeValue)
                {
                    parent = nodeNew;
                    if (nodeNew.Key > nodeValue)
                    {
                        nodeNew = nodeNew.Left;
                    }
                    else
                    {
                        nodeNew = nodeNew.Right;
                    }
                }

                //insert node value to destination
                if (nodeNew == null)
                {
                    nodeNew = CreateNode(nodeValue);
                    if (parent.Key < nodeValue)
                    {
                        parent.Right = nodeNew;
                    }
                    else
                    {
                        parent.Left = nodeNew;
                    }
                }
            }
        }

        public static void DisplayLeftNodeRight (this Node root)
        {
            if (root != null)
            {
                DisplayLeftNodeRight(root.Left);
                Console.Write(root.Key +" ");
                DisplayLeftNodeRight(root.Right);
            }
        }
    }
}
