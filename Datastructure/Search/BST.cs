using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Search
{
    public class Node
    {
        public int key;
        public string value;
        public Node leftChild, rightChild;

        public Node(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
    public class BST
    {
        Node root;
        public static void Execute()
        {
            BST searchTree = new BST();

            searchTree.Insert(10, "Ten");
            searchTree.Insert(20, "Twenty");
            searchTree.Insert(15, "Fifteen");

            Console.WriteLine(searchTree.FindMin().value);
            Console.WriteLine(searchTree.FindMax().value);
        }

        public void Insert(int key, string value)
        {
            Node newNode = new Node(key, value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (key < current.key)
                    {
                        current = current.leftChild;
                        if (current == null) //Parent is leaf node
                        {
                            parent.leftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public Node FindMin()
        {
            Node current = root;
            Node last = null;

            while (current != null)
            {
                last = current;
                current = current.leftChild;
            }
            return last;
        }

        public Node FindMax()
        {
            Node current = root;
            Node last = null;

            while (current != null)
            {
                last = current;
                current = current.rightChild;
            }
            return last;
        }

        public bool Remove(int key)
        {
            Node currentNode = root;
            Node parentNode = root;

            bool isLeftChild = false;

            //Search the node which we want to delete

            while (currentNode.key != key)
            {
                parentNode = currentNode;
                if (key < currentNode.key)
                {
                    isLeftChild = true;
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    isLeftChild = false;
                    currentNode = currentNode.rightChild;
                }

                if (currentNode == null)
                {
                    return false;
                }
            }

            //Yup!, We Found the node.
            Node nodeToDelete = currentNode;

            //If Leaf node
            if (currentNode.rightChild == null && currentNode.leftChild == null)
            {
                if (nodeToDelete == root)
                {
                    root = null;
                }
                else if (isLeftChild)
                {
                    parentNode.leftChild = null;
                }
                else
                {
                    parentNode.rightChild = null;
                }
            }
            else if (nodeToDelete.rightChild == null)//If has one child that is on Left
            {
                if (nodeToDelete == root)
                {
                    root = nodeToDelete.leftChild;
                }
                else if (isLeftChild)
                {
                    parentNode.leftChild = nodeToDelete.leftChild;
                }
                else
                {
                    parentNode.rightChild = nodeToDelete.leftChild;
                }
            }
            else if (nodeToDelete.leftChild == null)//If has one child that is on Right
            {
                if (nodeToDelete == root)
                {
                    root = nodeToDelete.rightChild;
                }
                else if (isLeftChild)
                {
                    parentNode.leftChild = nodeToDelete.rightChild;
                }
                else
                {
                    parentNode.rightChild = nodeToDelete.rightChild;
                }
            }
            else
            {
                Node successor = GetSuccessor(nodeToDelete);
                //Connect  parent of nodeToDelete to sucessor instead
                if (nodeToDelete == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parentNode.leftChild = successor;
                }
                else
                {
                    parentNode.rightChild = successor;
                }

                successor.leftChild = parentNode.leftChild;
            }

            //If has two children
            return true;
        }

        public Node GetSuccessor(Node nodeToDelete)
        {
            Node successorParent = nodeToDelete;
            Node successor = nodeToDelete;

            Node current = nodeToDelete.rightChild;// Go to the right child

            while (current != null) // Start going left down the tree untill has no left child 
            {
                successorParent = successor;
                successor = current;
                current = current.leftChild;
            }
            //If sucessor  not a right child
            if (successor != nodeToDelete.rightChild)
            {
                successorParent.leftChild = successor.rightChild;
                successor.rightChild = nodeToDelete.rightChild;
            }
            return successor;
        }
    }
}
