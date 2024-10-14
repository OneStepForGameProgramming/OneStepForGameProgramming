using UnityEngine;
using UnityEngine.EventSystems;
public class VirtualJoystick : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private const float _maxMagnitude = 100f;
    // Rect를 기반으로 한 Transform, 보통 UI에서 사용한다.
    [SerializeField]
    private RectTransform _handle;
    public void OnDrag(PointerEventData eventData)
    {
        // 1. 드래그 입력이 들어온 만큼 움직여준다.
        _handle.anchoredPosition += eventData.delta;
        // 2. 범위를 넘어간 경우, 최대 범위 내에서 움직여준다.
        // TODO
    }
    // 드래그 입력이 끝나면 위치를 초기화시킨다.
    public void OnEndDrag(PointerEventData eventData)
    {
        _handle.anchoredPosition = Vector3.zero;
    }
}