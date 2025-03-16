using Unity.VisualScripting;
using UnityEngine;

public class GunShootScript : GunCursorRotate
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private Transform bulletSpawnPoint;

    private Vector3 pointToMove;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {Shoot();}
    }

    private void Shoot()
    {
        if (Physics.Raycast(ray, out hit))
        {
            pointToMove = hit.point;
        }
        else
        {
            pointToMove = ray.GetPoint(100);
        }
        GameObject bullet = Instantiate(bulletPref, bulletSpawnPoint.position, Quaternion.identity);
    }
}
