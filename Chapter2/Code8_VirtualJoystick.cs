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
        // TODO
    }
    // �巡�� �Է��� ������ ��ġ�� �ʱ�ȭ��Ų��.
    public void OnEndDrag(PointerEventData eventData)
    {
        _handle.anchoredPosition = Vector3.zero;
    }
}