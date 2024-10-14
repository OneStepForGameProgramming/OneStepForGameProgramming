using UnityEngine;
/// <summary>
/// ������ �����ϸ� Ư�� ��ġ�� ���͸� �����Ѵ�.
/// </summary>
public class MonsterSpawner : MonoBehaviour
{
    private const int COUNT_TO_SPAWN = 5;
    private readonly Vector3 SpawnOriginPosition = new Vector3(-2, 0, 0);
    private readonly Vector3 SpawnDistance = new Vector3(0, 1, 0);
    // ����Ƽ ������ �󿡼� ���̴� ����̴�.
    [Tooltip("���� ������")]
    // ����Ƽ ������ �� ���̵��� Ȥ�� ���� ���� ���� ����ȭ�� �� ����Ѵ�.
    [SerializeField]
    private GameObject _monster;
    // ������Ʈ�� ���ʷ� ����� �� ȣ��ȴ�.
    private void Start()
    {
        for (int i = 0; i < COUNT_TO_SPAWN; i++)
        {
            // ���� ���� ��ġ���� �̸� ���ص� ���ݸ�ŭ ���� �־�����.
            var position = SpawnOriginPosition + SpawnDistance * i;
            // ���͸� position�� Quaternion.identity(ȸ�� ����)������ �����Ѵ�.
             var monsterObject = GameObject.Instantiate(_monster, position, Quaternion.identity);
            // ��ȯ�� ������ �̸��� �����Ѵ�.
            monsterObject.name = $"Monster {i}";
        }
    }
}