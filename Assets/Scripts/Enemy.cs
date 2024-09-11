using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    
    private Vector3 _direction = Vector3.zero;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }
}
