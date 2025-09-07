using System.Linq;
using UnityEngine;

public class Example : MonoBehaviour
{
    private ShootingController[] shootingControllers;
    private void Awake()
    {
        var turrets = GameObject.FindGameObjectsWithTag("Turret");
        shootingControllers = turrets.Select(turret => turret.GetComponent<ShootingController>()).ToArray();
        foreach (var shootingController in shootingControllers)
        {
            shootingController.SetShootPattern(new StraightShootPattern());
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var controller in shootingControllers)
            {
                controller.SetShootPattern(new StraightShootPattern());
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            foreach (var controller in shootingControllers)
            {
                controller.SetShootPattern(new WiggleShootPattern());
            }
        }
    }
    
}