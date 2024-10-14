using UnityEngine;
public class PlatformMover : MonoBehaviour
{
    private float _minimumX = -2f;
    private float _maximumX = 2f;
    private float _movingSpeed = 3f;

    private void Update()
    {
        // 1. ���� ��ġ�� �����´�.
        Vector3 currentPosition = transform.position;
        // 2. x������ �̵��� ���� ����Ѵ�.
        float movingAmount = _movingSpeed * Time.deltaTime;
        // 3. �̵��� ���� ���� ��ġ�� ���Ѵ�.
        currentPosition.x += movingAmount;
        // 4. �ִ�, �ּڰ��� �Ѿ ��� �ִ�, �ּڰ����� �����Ѵ�.
        if (currentPosition.x < _minimumX)
        {
            currentPosition.x = _minimumX;
            _movingSpeed *= -1f;
        }
        else if (currentPosition.x > _maximumX)
        {
            currentPosition.x = _maximumX;
            _movingSpeed *= -1f;
        }
        // 5. ��ġ�� �����Ѵ�.
        transform.position = currentPosition;
    }
}