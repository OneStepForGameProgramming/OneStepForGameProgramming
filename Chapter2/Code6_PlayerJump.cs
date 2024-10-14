using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private const float GRAVITY = 9.8f;
    private const float JUMP_POWER = 5;
    // ���� ���� �ð�
    private float _airborneStartTime;
    // ���� ������ ����
    private float _airborneStartHeight;
    // ���� ���� �ӵ�
    private float _airborneStartVelocity = 0;
    // ���� ��Ҵ��� Ȯ��
    private bool _isOnGround = false;
    // ������ �ߴ��� Ȯ��
    private bool _isOnJump = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isOnGround)
            {
                _isOnJump = true;
                _airborneStartTime = Time.time;
                _airborneStartHeight = transform.position.y;
                _airborneStartVelocity = JUMP_POWER;
            }
        }
        if (!_isOnGround || _isOnJump)
        {
            float t = Time.time - _airborneStartTime;
            Vector3 newPosition = transform.position;
            float heightChange = _airborneStartVelocity * t - GRAVITY * t * t / 2;
            newPosition.y = heightChange + _airborneStartHeight;
            transform.position = newPosition;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnJump = false;
            _isOnGround = true;
            _airborneStartVelocity = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = false;
            _airborneStartTime = Time.time;
        }
    }
}
