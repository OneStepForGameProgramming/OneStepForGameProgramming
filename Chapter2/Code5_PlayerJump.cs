using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private const float GRAVITY = 9.8f;
    private const float JUMP_POWER = 5;
    private bool _isOnGround = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ���� ���, ������ �����Ѵ�.
        }
        if (!_isOnGround)
        {
            // ���� �ƴ� ���, ���̸� ����ؼ� ���ο� ��ġ�� �����Ѵ�.
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // ���� ���� ���
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // ������ ��� ���
        }
    }
}
