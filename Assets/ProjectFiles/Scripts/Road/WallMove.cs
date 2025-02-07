using UnityEngine;

public class WallMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
