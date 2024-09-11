using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Vector3 _direction;

    public void Create()
    {
        Enemy enemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        enemy.Init(_direction);
    }
}