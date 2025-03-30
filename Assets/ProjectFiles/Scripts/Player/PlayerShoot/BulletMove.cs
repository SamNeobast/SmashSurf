using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GunCursorRotate gunTarget;
    private Vector3 targetPosition;
    private int speed = 6;
    private Rigidbody rb;

    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        rb = GetComponent<Rigidbody>();
        gunTarget = FindAnyObjectByType<GunCursorRotate>();

        if (gunTarget != null)
        {
            targetPosition = gunTarget.targetPosition;
        }
    }

    private void FixedUpdate()
    {
        if (gunTarget != null)
        {
            Vector3 direction = (targetPosition - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WallMove>() != null)
        {
            Destroy(collision.gameObject);
            scoreManager.AddScore(10);
            if (collision.gameObject.name == "WallGold Variant(Clone)")
            {
                scoreManager.AddScore(10);
                scoreManager.ShowScore();
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.GetComponent<BulletMove>() != null)
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
