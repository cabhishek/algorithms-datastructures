using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class TempBST
    {
        private Queue<IComparable> inOrderQueue;
        private IComparable[] nodeData;
        private BSTNode root;


        public TempBST()
        {
            root = null;
        }

        public void insert(IComparable item)
        {
            root = recInsert(root, item);
        }

        private BSTNode recInsert(BSTNode node, IComparable item)
        {
            if (node == null)
                return new BSTNode {data = item};

            if (item.CompareTo(node.data) < 0) //go to left 
                node.left = recInsert(node.left, item);

            if (item.CompareTo(node.data) > 0) // go to right
                node.right = recInsert(node.right, item);

            return node;
        }

        private Queue<IComparable> getIorderQueue()
        {
            inOrderQueue = new Queue<IComparable>();
            inOrder(root);
            return inOrderQueue;
        }

        private void inOrder(BSTNode tree)
        {
            if (tree == null) return;
            inOrder(tree.left);
            inOrderQueue.Enqueue(tree.data);
            inOrder(tree.right);
        }

        public void printInOrder()
        {
            foreach (IComparable inOrder in getIorderQueue())
            {
                Console.WriteLine(inOrder);
            }
        }


        public void balance()
        {
            Queue<IComparable> treeData = getIorderQueue();
            nodeData = treeData.ToArray();
            root = null; // delete old tree .. ie let it get GC and then start all over again
            balanceInsert(0, nodeData.Length - 1);
        }

        private void balanceInsert(int low, int high)
        {
            if (low == high) // when there is only one data to be inserted
                insert(nodeData[low]);
            else if (low + 1 == high) // when there are only two data elements to be inserted.
            {
                insert(nodeData[low]);
                insert(nodeData[high]);
            }
            else
            {
                int mid = (low + high)/2;
                insert(nodeData[mid]);
                balanceInsert(low, mid - 1);
                balanceInsert(mid + 1, high);
            }
        }

        public void delete(IComparable item)
        {
            root = recDelete(item, root);
        }

        private BSTNode recDelete(IComparable item, BSTNode tree)
        {
            if (item.CompareTo(tree.data) < 0) // go left
                tree.left = recDelete(item, tree.left);
            else if (item.CompareTo(tree.data) > 0) // go right
                tree.right = recDelete(item, tree.right);
            else
                tree = deleteNode(tree); // found the node .. so go ahead and delete it

            return tree;
        }

        private BSTNode deleteNode(BSTNode tree)
        {
            if (tree.right == null && tree.left == null) // delete the leaf node
                return null;
            else if (tree.left == null) // node to be delete doesnt have left child so return right one
                return tree.right;
            else if (tree.right == null) // no right child so return left
                return tree.left;
            else
            {
                IComparable temp = getDescendentValue(tree.left); // get data to be replaced
                tree.data = temp; // copy that data 
                tree.left = recDelete(temp, tree.left);
                return tree;
            }
        }

        private IComparable getDescendentValue(BSTNode tree)
        {
            while (tree.right != null)
            {
                tree = tree.right;
            }

            return tree.data;
        }

        public int getNodeLevel(IComparable item)
        {
            return find_NodeLevel(root, item);
        }

        private int find_NodeLevel(BSTNode tree, IComparable item)
        {
            int level = 0;

            while (tree != null)
            {
                if (item.CompareTo(tree.data) == 0)
                    return level++;
                if (item.CompareTo(tree.data) < 0) // if item less go left
                {
                    tree = tree.left;
                    level++;
                }
                else if (item.CompareTo(tree.data) > 0) // go right
                {
                    tree = tree.right;
                    level++;
                }
            }

            return level;
        }

        public void PrintRootToLeavePath()
        {
            IComparable[] nodes  = new IComparable[1000];

            printPath(nodes, root, 0);
        }


        private void printPath(IComparable[] toPrintNodes, BSTNode tree, int len)
        {
            if(tree == null) return;
            toPrintNodes[len] = tree.data;
            len++;
            if (tree.left == null && tree.right == null)
                printTree(toPrintNodes,len);
            else
            {
                printPath(toPrintNodes,tree.left,len);
                printPath(toPrintNodes,tree.right,len);
            }
        }

        private void printTree(IComparable[] treeToPrint, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(treeToPrint[i]);
            }
        }
    }

    public class BSTNode
    {
        public IComparable data;
        public BSTNode left;
        public BSTNode right;
    }
}