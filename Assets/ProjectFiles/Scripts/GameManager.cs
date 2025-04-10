using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject LoseWindow;
    [SerializeField] GameObject PauseWindow;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (LoseWindow.activeSelf == true)
            {
                PauseWindow.SetActive(false);
                Debug.Log("You lost restart the game");
            }
            if (LoseWindow.activeSelf == false)
            {
                Time.timeScale = 0;
                PauseWindow.SetActive(true);
            }
        }
    }
    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ContinueButton()
    {
        Time.timeScale = 1f;
        PauseWindow.SetActive(false);
    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1f;
    }
}
