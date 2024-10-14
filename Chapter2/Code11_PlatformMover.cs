using UnityEngine;
public class PlatformMover : MonoBehaviour
{
    private float _minimumX = -2f;
    private float _maximumX = 2f;
    private float _movingSpeed = 3f;

    private void Update()
    {
        // 1. 현재 위치를 가져온다.
        Vector3 currentPosition = transform.position;
        // 2. x축으로 이동할 양을 계산한다.
        float movingAmount = _movingSpeed * Time.deltaTime;
        // 3. 이동할 양을 현재 위치에 더한다.
        currentPosition.x += movingAmount;
        // 4. 최댓값, 최솟값을 넘어간 경우 최댓값, 최솟값으로 설정한다.
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
        // 5. 위치를 설정한다.
        transform.position = currentPosition;
    }
}