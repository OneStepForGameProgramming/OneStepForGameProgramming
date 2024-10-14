// ����� ����
using UnityEngine;
public class Tree : MonoBehaviour
{
    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
    // ���� Ʈ���� ����
    public class BinaryTree
    {
        // ��Ʈ ���
        public TreeNode Root;
        public BinaryTree()
        {
            Root = null;
        }
        // ���ο� �������� ����
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }
        // �� Ʈ���� ��� �����Ͱ� �θ� ��庸�� ũ�ų� ������ ������,
        // ������ ���ʿ� �ִ� �����̴�.
        private TreeNode InsertRec(TreeNode root, int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                return root;
            }
            if (data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if (data >= root.Data)
            {
                root.Right = InsertRec(root.Right, data);
            }
            return root;
        }
        // Inorder ��ȸ �� ���
        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Debug.Log(node.Data.ToString());
                InOrderTraversal(node.Right);
            }
        }
        // Preorder ��ȸ �� ���
        public void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Debug.Log(node.Data.ToString());
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }
        // Postorder ��ȸ �� ���
        public void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Debug.Log(node.Data.ToString());
            }
        }
    }
}