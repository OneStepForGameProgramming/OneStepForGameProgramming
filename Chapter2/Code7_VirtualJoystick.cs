using UnityEngine;
using UnityEngine.EventSystems;
// �巡�׸� ����ϱ� ���� ���� ����� ������ �������̽��� �߰��ؾ� �Ѵ�.
public class VirtualJoystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("�巡�׸� �����մϴ�.");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("�ڵ��� ������ ����� �ʰ� �������ݴϴ�.");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("�ڵ��� �ʱ�ȭ�մϴ�.");
    }
}