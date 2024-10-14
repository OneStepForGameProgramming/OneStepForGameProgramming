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
            // 땅인 경우, 점프를 시작한다.
        }
        if (!_isOnGround)
        {
            // 땅이 아닌 경우, 높이를 계산해서 새로운 위치를 설정한다.
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // 땅에 닿은 경우
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // 땅에서 벗어난 경우
        }
    }
}
