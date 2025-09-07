using UnityEngine;

public class TopRotation: MonoBehaviour
{
    [SerializeField] private float lookRadius;
    void Update()
    {
        var colliders = Physics.OverlapSphere(transform.position, lookRadius, LayerMask.GetMask("Enemy"));

        var minDist = float.MaxValue;
        Collider closestCollider = null;
        foreach (var collider in colliders)
        {
            var curDist = Vector3.Distance(collider.transform.position, transform.position);
            if (curDist < minDist)
            {
                minDist = curDist;
                closestCollider = collider;
            }
        }

        transform.LookAt(closestCollider.transform.position);
    }
}