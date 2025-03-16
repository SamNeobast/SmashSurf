using UnityEngine;

public class GunCursorRotate : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private bool lockYAxis = true;
    protected Ray ray;
    public Vector3 targetPosition;
    protected RaycastHit hit;
    void Update()
    {
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) 
        {
            targetPosition = hit.point; 
            if (lockYAxis) targetPosition.y = transform.position.y; 

            transform.LookAt(targetPosition);
        }
    }
}
