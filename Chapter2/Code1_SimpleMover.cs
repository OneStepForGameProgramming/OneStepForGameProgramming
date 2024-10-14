using UnityEngine;
// MonoBehaviour는 유니티 컴포넌트로 사용하기 위해 상속하는 클래스이다.
public class SimpleMover : MonoBehaviour
{
    // 컴포넌트가 활성화되어 있는 경우, 매 프레임마다 호출되는 메서드이다.
    private void Update()
    {
        // 만약 스페이스바를 누른다면
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 해당 컴포넌트를 지닌 오브젝트의 포지션을 증가시킨다.
            transform.position += new Vector3(1, 0, 0);
        }
    }
}