using Unity.VisualScripting;
using UnityEngine;

public class GunShootScript : GunCursorRotate
{
    [SerializeField] AudioSource ShootSound;
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private Transform bulletSpawnPoint;
    private float timer = 0.6f;
    private Vector3 pointToMove;
    private void Update()
    {
        timer -= Time.deltaTime;
        
        if (Input.GetMouseButtonDown(0))
        {
            if (timer <= 0)
            {
                Shoot();
                ShootSound.Play();
                timer = 0.6f;
            }
        }
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
