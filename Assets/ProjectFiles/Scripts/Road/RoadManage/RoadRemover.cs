using UnityEngine;

public class RoadRemover : MonoBehaviour
{
    [SerializeField] Transform spawner;
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = spawner.position;
    }
}
