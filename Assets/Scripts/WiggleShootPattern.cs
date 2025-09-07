using System.Collections.Generic;
using UnityEngine;

public class WiggleShootPattern: IShootPattern
{
    private float _wiggleFrequency = 50f;
    private float _wiggleAmplitude = 20f;
    
    public void UpdateBullet(Transform bulletTransform, float bulletSpeed)
    {
        bulletTransform.Translate(bulletTransform.forward * (bulletSpeed * Time.deltaTime));
        bulletTransform.Translate(bulletTransform.right * (20f * (Time.deltaTime * Mathf.Sin(50f * Time.time))));
    }
}