using System.Collections;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    private IShootPattern _shootPattern;
    private Transform _spawnPoint;

    private void Awake()
    {
        _spawnPoint = transform.Find("Top").Find("BulletSpawnPoint");
        StartCoroutine(Shoot());
    }
    
    private IEnumerator Shoot()
    {
        while (true)
        {
            var newBullet = Instantiate(bullet, _spawnPoint.position, _spawnPoint.rotation);
            newBullet.Initialize(_shootPattern, 10);
            yield return new WaitForSeconds(1);
        }
    }
    
    public void SetShootPattern(IShootPattern shootPattern)
    {
        _shootPattern = shootPattern;
    }
}
