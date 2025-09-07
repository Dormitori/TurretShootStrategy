using System.Collections.Generic;
using UnityEngine;

public class StraightShootPattern: IShootPattern
{
    public void UpdateBullet(Transform bulletTransform, float bulletSpeed)
    {
        bulletTransform.Translate(bulletTransform.forward * (bulletSpeed * Time.deltaTime));
    }
}