using UnityEngine;

public class LinkedListNode
{
    // ���� ����� ������
    public int Data;
    // ���� ��尡 ����ų ���� ���
    public LinkedListNode Next;
    // ����� ����
    public LinkedListNode(int data)
    {
        Data = data;
        Next = null;
    }
}
public class LinkedList
{
    // ��ũ�� ����Ʈ�� ù ��带 ����ų ������
    public LinkedListNode Head;
    // ��ũ�� ����Ʈ�� ������
    public LinkedList()
    {
        Head = null;
    }
    // ��ũ�� ����Ʈ�� ����
    public void Insert(int data)
    {
        var newNode = new LinkedListNode(data);
        if (Head == null)
        {
            Head = newNode;
        }
        // ��ũ�� ����Ʈ�� ��尡 �ϳ��� �����ϸ�
        // �� ����� next�� �� ��带 ����
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    // ��ũ�� ����Ʈ ��ü ���
    public void Display()
    {
        var current = Head;
        while (current != null)
        {
            // current.Data ���
            Debug.Log(current.Data.ToString());
            // ���� �����ͷ� �̵�
            current = current.Next;
        }
    }
}