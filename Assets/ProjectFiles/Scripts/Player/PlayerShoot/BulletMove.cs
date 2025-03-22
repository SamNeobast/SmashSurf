using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GunCursorRotate gunTarget;
    private Vector3 targetPosition;
    private int speed = 10;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gunTarget = FindAnyObjectByType<GunCursorRotate>();
        targetPosition = gunTarget.targetPosition;
    }
    
    private void FixedUpdate()
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WallMove>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
         if (collision.gameObject.CompareTag("BackgroundWall"))
        {
            Destroy(gameObject);
        }
    }

}
