using Unity.VisualScripting;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    [SerializeField] GameObject loseWindow;
    [SerializeField] float speed = 1f;
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
