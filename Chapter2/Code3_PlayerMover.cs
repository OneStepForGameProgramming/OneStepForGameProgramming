using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private void Update()
    {
        // 입력 시스템에서 Horizontal로 주어진 값을 받아온다(조이스틱의 좌우, 키보드의 방향키 등)
        float horizontalInput = Input.GetAxis("Horizontal");
        // 입력이 주어진다면 보통 좌는 -1, 우는 1로 주어진다.
        if (horizontalInput < 0 || horizontalInput > 0)
        {
            transform.position += new Vector3(1, 0, 0);
        }
    }
}