using UnityEngine;

public class RoadRemover : MonoBehaviour
{
    [SerializeField] Transform spawner;
    [SerializeField] RoadSpawner RoadSpawner;
    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //collision.gameObject.transform.position = spawner.position;
        Destroy(collision.gameObject);
        RoadSpawner.roads.Remove(collision.gameObject);
    }
}
