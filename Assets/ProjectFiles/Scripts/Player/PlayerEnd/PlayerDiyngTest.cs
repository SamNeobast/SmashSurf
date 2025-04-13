using UnityEngine;

public class PlayerDiyngTest : MonoBehaviour
{
    [SerializeField] AudioSource Die;
    [SerializeField] AudioSource BackGroundMusic;
    [SerializeField] GameObject loseWindow;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WallMove>())
        {
            loseWindow.SetActive(true);
            Die.Play();
            BackGroundMusic.Stop();
            Time.timeScale = 0;
        }
    }
}
