using UnityEngine;
// MonoBehaviour�� ����Ƽ ������Ʈ�� ����ϱ� ���� ����ϴ� Ŭ�����̴�.
public class SimpleMover : MonoBehaviour
{
    // ������Ʈ�� Ȱ��ȭ�Ǿ� �ִ� ���, �� �����Ӹ��� ȣ��Ǵ� �޼����̴�.
    private void Update()
    {
        // ���� �����̽��ٸ� �����ٸ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �ش� ������Ʈ�� ���� ������Ʈ�� �������� ������Ų��.
            transform.position += new Vector3(1, 0, 0);
        }
    }
}