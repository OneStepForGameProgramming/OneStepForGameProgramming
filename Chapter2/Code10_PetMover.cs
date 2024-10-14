using UnityEngine;
public class PetMover : MonoBehaviour
{
    private float _currentAngle = 0f;
    private float _movingSpeed = 3f;
    private float _movingRadius = 2f;
    private void Update()
    {
        // 1. ������ ����Ѵ�.
        _currentAngle += _movingSpeed * Time.deltaTime;
        // 2. ������ ���� ��ġ�� ����Ѵ�.
        var currentPosition = new Vector3(_movingRadius * Mathf.Cos(_currentAngle), _movingRadius * Mathf.Sin(_currentAngle), 0f);
        // 3. ��ġ�� �����Ѵ�.
        transform.localPosition = currentPosition;
    }
}
