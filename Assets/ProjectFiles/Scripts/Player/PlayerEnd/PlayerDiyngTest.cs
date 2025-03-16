using UnityEngine;

public class PlayerDiyngTest : MonoBehaviour
{
    [SerializeField] GameObject loseWindow;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WallMove>())
        {
            loseWindow.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
