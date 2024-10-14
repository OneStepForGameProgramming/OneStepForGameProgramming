using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private const float SPEED = 1;
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput < 0 || horizontalInput > 0)
        {
            // Time.deltaTIme: ����Ƽ���� �����ϴ� ������� ������ ���������� ���� �帥 �ð�(��)�� ���Ѵ�.
            float movementDistance = horizontalInput * Time.deltaTime * SPEED;
            transform.position += new Vector3(movementDistance, 0, 0);
        }
    }
}