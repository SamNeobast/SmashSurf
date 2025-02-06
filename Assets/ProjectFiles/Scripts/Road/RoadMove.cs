using UnityEngine;

public class RoadMove : MonoBehaviour
{
    [SerializeField] private float timer = 0.51f;
    [SerializeField] private float timerMax = 0.5f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            gameObject.transform.position += new Vector3(0,0,-0.5f);
            timer = timerMax;
        }

    }
}
