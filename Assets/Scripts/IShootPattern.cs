using UnityEngine;

public interface IShootPattern
{
    public void UpdateBullet(Transform bulletTransform, float bulletSpeed);
}