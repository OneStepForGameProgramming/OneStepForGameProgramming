using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private const float SPEED = 1;
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput < 0 || horizontalInput > 0)
        {
            // Time.deltaTIme: 유니티에서 제공하는 기능으로 직전의 프레임으로 부터 흐른 시간(초)을 뜻한다.
            float movementDistance = horizontalInput * Time.deltaTime * SPEED;
            transform.position += new Vector3(movementDistance, 0, 0);
        }
    }
}