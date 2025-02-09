using UnityEngine;

public class GunCursorRotate : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private bool lockYAxis = true;
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) 
        {
            Vector3 targetPosition = hit.point; 
            if (lockYAxis) targetPosition.y = transform.position.y; 

            transform.LookAt(targetPosition);
        }
    }
}
