using UnityEngine;

public class RoadMove : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private void FixedUpdate()
    {
        gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
