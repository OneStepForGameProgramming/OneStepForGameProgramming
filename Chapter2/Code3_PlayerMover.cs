using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private void Update()
    {
        // �Է� �ý��ۿ��� Horizontal�� �־��� ���� �޾ƿ´�(���̽�ƽ�� �¿�, Ű������ ����Ű ��)
        float horizontalInput = Input.GetAxis("Horizontal");
        // �Է��� �־����ٸ� ���� �´� -1, ��� 1�� �־�����.
        if (horizontalInput < 0 || horizontalInput > 0)
        {
            transform.position += new Vector3(1, 0, 0);
        }
    }
}