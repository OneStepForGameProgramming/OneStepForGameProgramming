using UnityEngine;
using UnityEngine.EventSystems;
public class VirtualJoystick : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private const float _maxMagnitude = 100f;
    // Rect�� ������� �� Transform, ���� UI���� ����Ѵ�.
    [SerializeField]
    private RectTransform _handle;
    public void OnDrag(PointerEventData eventData)
    {
        // 1. �巡�� �Է��� ���� ��ŭ �������ش�.
        _handle.anchoredPosition += eventData.delta;
        // 2. ������ �Ѿ ���, �ִ� ���� ������ �������ش�.
        Vector2 currentPosition = _handle.anchoredPosition;
        float currentMagnitude = Mathf.Sqrt(currentPosition.x * currentPosition.x +
        currentPosition.y * currentPosition.y);
        float currentAngleRadian = Mathf.Atan2(currentPosition.y, currentPosition.x);
        // �ִ� ���� ���� ����
        float clampedMagnitude = Mathf.Min(currentMagnitude, _maxMagnitude);
        var clampedPosition = new Vector2(clampedMagnitude * Mathf.Cos(currentAngleRadian), clampedMagnitude * Mathf.Sin(currentAngleRadian));
        // ��ġ�� ������ ���ͷ� ����
        _handle.anchoredPosition = clampedPosition;
    }
    // �巡�� �Է��� ������ ��ġ�� �ʱ�ȭ��Ų��.
    public void OnEndDrag(PointerEventData eventData)
    {
        _handle.anchoredPosition = Vector3.zero;
    }
}