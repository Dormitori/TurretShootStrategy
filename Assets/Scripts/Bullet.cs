using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const float DESTROY_DISTANCE = 5;
    private IShootPattern _shootPattern;
    private float _bulletSpeed;
    
    private void Start()
    {
        AudioManager.Instance.Play("shoot");
    }

    public void Initialize(IShootPattern shootPattern, float bulletSpeed)
    {
        _shootPattern = shootPattern;
        _bulletSpeed = bulletSpeed;
    }

    private void Update()
    {
        if (_shootPattern != null)
        {
            _shootPattern.UpdateBullet(transform, _bulletSpeed);
        }
    }
}
