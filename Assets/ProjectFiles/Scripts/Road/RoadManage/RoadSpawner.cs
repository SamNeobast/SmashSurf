using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private GameObject roadPref;
    [SerializeField] private Transform parent;
    public List<GameObject> roads = new List<GameObject>(5);

    private GameObject newRoad;

    void Update()
    {
        if (roads.Count <= 3)
        {
            newRoad = Instantiate(roadPref,gameObject.transform.position, Quaternion.identity, parent);
            roads.Add(newRoad);
        }
    }
}
