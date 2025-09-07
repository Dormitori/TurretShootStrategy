using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.position += direction * (speed * Time.deltaTime);
    }
}
