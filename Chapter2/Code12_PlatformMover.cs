using UnityEngine;
public class PlatformMover : MonoBehaviour
{
    private Vector3 _startPosition = new Vector3(-2, 3, 0);
    private Vector3 _endPosition = new Vector3(2, 3, 0);
    private float _duration = 2.0f;
    private float _startTime;
    private void Start()
    {
        _startTime = Time.time;
    }
    private void Update()
    {
        float elapsedTime = Time.time - _startTime;
        if (elapsedTime >= _duration)
        {
            // ������ �ٲ��ش�.
            Vector3 temp = _startPosition;
            _startPosition = _endPosition;
            _endPosition = temp;
            // ���� �ð��� �����Ѵ�.
            elapsedTime = elapsedTime - _duration;
            _startTime = Time.time;
        }
        // EaseInOutElastic���� �̵�
        float t = elapsedTime / _duration;
        float easedT = EaseInOutElastic(t);
        // easedT�� �̿��Ͽ� ��ġ�� �����Ѵ�.
        transform.position = Vector3.Lerp(_startPosition, _endPosition, easedT);
    }
    private float EaseInOutElastic(float x)
    {
        var c5 = (2 * Mathf.PI) / 4.5f;
        if (x == 0)
        {
            return 0;
        }
        if (x == 1)
        {
            return 1;
        }
        if (x < 0.5f)
        {
            return -((Mathf.Pow(2, 20 * x - 10) * Mathf.Sin((20 * x - 11.125f) *
           c5)) / 2);
        }
        return (Mathf.Pow(2, -20 * x + 10) * Mathf.Sin((20 * x - 11.125f) * c5)) / 2 + 1;
    }
}